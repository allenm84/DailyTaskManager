using System;
using System.Collections.Generic;
using System.Drawing;
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
    private DateTime last;
    private bool moveRight;
    private List<Star> stars;
    private GridView view;
    private float x;

    public Sparkle(int rowHandle, GridView view)
    {
      this.view = view;
      this.RowHandle = rowHandle;
      this.last = DateTime.Now;
      this.stars = new List<Star>();
      this.moveRight = true;
    }

    public int RowHandle { get; private set; }

    public bool IsFinished
    {
      get { return !this.moveRight && this.stars.Count == 0; }
    }

    public void Update(int updates = 1)
    {
      while (updates > 0)
      {
        var now = DateTime.Now;
        var timeSpan = now - this.last;
        if (this.moveRight)
        {
          var gridViewInfo = (GridViewInfo)this.view.GetViewInfo();
          var bounds = gridViewInfo.GetGridRowInfo(this.RowHandle).Bounds;
          var num = SmoothStep(2f, 5f, (float)random.NextDouble());
          var yc = SmoothStep(bounds.Top + num, bounds.Bottom - num, (float)random.NextDouble());
          var star = new Star(num, this.x, yc);
          star.SecondsRemaining = 0.35;
          this.stars.Add(star);
          this.x += num;
          this.moveRight = (this.x <= bounds.Right);
        }
        for (var i = this.stars.Count - 1; i > -1; i--)
        {
          var star2 = this.stars[i];
          star2.SecondsRemaining -= timeSpan.TotalSeconds;
          if (star2.SecondsRemaining <= 0.0)
          {
            this.stars.RemoveAt(i);
          }
        }
        this.last = now;
        updates--;
      }
    }

    public void Render(Graphics gra)
    {
      foreach (var current in this.stars)
      {
        var alpha = (int)(255.0 * (current.SecondsRemaining / 0.35));
        using (var pen = new Pen(Color.FromArgb(alpha, Color.Purple)))
        {
          current.Render(gra, pen);
        }
      }
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
      private PointF[] points;

      static Star()
      {
        sin36 = (float)Math.Sin(0.62831853071795862);
        sin72 = (float)Math.Sin(1.2566370614359172);
        cos36 = (float)Math.Cos(0.62831853071795862);
        cos72 = (float)Math.Cos(1.2566370614359172);
      }

      public Star(float r, float xc, float yc)
      {
        this.points = Calculate5StarPoints(r, xc, yc);
      }

      public double SecondsRemaining { get; set; }

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
    }

    #endregion
  }
}