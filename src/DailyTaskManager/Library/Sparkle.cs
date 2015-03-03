using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DailyTaskManager
{
  public class Sparkle
  {
    private const double TotalSeconds = 0.35;
    private const double HalfTotalSeconds = 0.175;

    private static Random random = new Random();
    static float mu() { return (float)random.NextDouble(); }

    private DateTime last;
    private List<Star> stars;
    private GridView view;
    private int rounds = 0;

    public Sparkle(int rowHandle, GridView view)
    {
      this.view = view;
      this.RowHandle = rowHandle;
      this.last = DateTime.Now;
      this.stars = new List<Star>();
    }

    public int RowHandle { get; private set; }

    public bool IsFinished
    {
      get { return (rounds >= 3) && this.stars.Count == 0; }
    }

    public void Update()
    {
      var now = DateTime.Now;
      var timeSpan = now - this.last;

      var gridViewInfo = (GridViewInfo)this.view.GetViewInfo();
      var rect = gridViewInfo.GetGridRowInfo(this.RowHandle).Bounds;

      if (rounds < 3)
      {
        for (int i = 0; i < 8; ++i)
        {
          float r = SmoothStep(1, 3, mu());
          float x = SmoothStep(rect.Left + r, rect.Right - r, mu());
          float y = SmoothStep(rect.Top + r, rect.Bottom - r, mu());

          var star = new Star(r, x, y);
          star.Remaining = random.Next(65, 125);
          stars.Add(star);
        }
      }

      for (int i = stars.Count - 1; i > -1; --i)
      {
        var star = stars[i];
        AdjustStar(star, timeSpan);
        if (star.Remaining <= 0)
        {
          stars.RemoveAt(i);
          ++rounds;
        }
      }

      this.last = now;
    }

    private void AdjustStar(Star star, TimeSpan elapsed)
    {
      star.Remaining -= elapsed.TotalMilliseconds;
      star.Total += elapsed.TotalSeconds;
      star.Angle = (Math.Sin(star.Total) + 1d) / 2d;
    }

    private void RenderStar(Star star, Graphics graphics)
    {
      var bounds = star.Bounds;
      using (var ellipsePath = new GraphicsPath())
      {
        ellipsePath.AddEllipse(bounds);
        using (var brush = new PathGradientBrush(ellipsePath))
        {
          brush.CenterPoint = new PointF(bounds.Width / 2f, bounds.Height / 2f);
          brush.CenterColor = Color.Gold;
          brush.SurroundColors = new[] { Color.White };
          brush.FocusScales = new PointF(0, 0);
          brush.SetBlendTriangularShape((float)star.Angle);

          var pts = star.Points.ToArray();
          graphics.FillPolygon(brush, pts);
          graphics.DrawPolygon(Pens.Yellow, pts);
        }
      }
    }

    public void Render(Graphics gra)
    {
      var state = gra.Save();

      gra.CompositingQuality = CompositingQuality.HighQuality;
      gra.InterpolationMode = InterpolationMode.HighQualityBicubic;
      gra.PixelOffsetMode = PixelOffsetMode.HighQuality;
      gra.SmoothingMode = SmoothingMode.AntiAlias;
      stars.ForEach(s => RenderStar(s, gra));

      gra.Restore(state);
    }

    private static float Clamp(float value, float min, float max)
    {
      return Math.Max(min, Math.Min(value, max));
    }

    private static float Lerp(float x, float y, float mu, bool clamp = true)
    {
      if (clamp)
      {
        mu = Clamp(mu, 0f, 1f);
      }
      return x * (1f - mu) + y * mu;
    }

    private static float SmoothStep(float value1, float value2, float amount)
    {
      var num = Clamp(amount, 0f, 1f);
      return Lerp(value1, value2, num * num * (3f - 2f * num), true);
    }

    #region Nested type: Star

    private class Star
    {
      private static readonly float sin36;
      private static readonly float sin72;
      private static readonly float cos36;
      private static readonly float cos72;

      static Star()
      {
        sin36 = (float)Math.Sin(0.62831853071795862);
        sin72 = (float)Math.Sin(1.2566370614359172);
        cos36 = (float)Math.Cos(0.62831853071795862);
        cos72 = (float)Math.Cos(1.2566370614359172);
      }

      private PointF[] points;
      private RectangleF bounds;

      public double Remaining { get; set; }
      public double Total { get; set; }
      public double Angle { get; set; }

      public IEnumerable<PointF> Points { get { return this.points; } }
      public RectangleF Bounds { get { return this.bounds; } }

      public Star(float r, float xc, float yc)
      {
        this.points = Calculate5StarPoints(r, xc, yc);
        this.bounds = CalculateBounds(points);
      }

      public void Render(Graphics graphics, Pen pen)
      {
        graphics.DrawPolygon(pen, this.points);
      }

      private static PointF[] Calculate5StarPoints(float r, float xc, float yc)
      {
        var num = r * cos72 / cos36;
        return new[]
        {
          new PointF(xc, yc - r),
          new PointF(xc + num * sin36, yc - num * cos36),
          new PointF(xc + r * sin72, yc - r * cos72),
          new PointF(xc + num * sin72, yc + num * cos72),
          new PointF(xc + r * sin36, yc + r * cos36),
          new PointF(xc, yc + num),
          new PointF(xc - r * sin36, yc + r * cos36),
          new PointF(xc - num * sin72, yc + num * cos72),
          new PointF(xc - r * sin72, yc - r * cos72),
          new PointF(xc - num * sin36, yc - num * cos36)
        };
      }

      private static RectangleF CalculateBounds(IEnumerable<PointF> points)
      {
        float
          left = float.MaxValue,
          right = float.MinValue,
          top = float.MaxValue,
          bottom = float.MinValue;
        foreach (var pt in points)
        {
          left = Math.Min(pt.X, left);
          right = Math.Max(pt.X, right);
          top = Math.Min(pt.Y, top);
          bottom = Math.Max(pt.Y, bottom);
        }
        return RectangleF.FromLTRB(left, top, right, bottom);
      }
    }

    #endregion
  }
}