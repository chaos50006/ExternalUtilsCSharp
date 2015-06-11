﻿using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalUtilsCSharp.SharpDXRenderer.Controls
{
    public class SharpDXButton : SharpDXLabel
    {
        public SharpDXButton()
        {
            this.FillParent = true;
        }
        public override void Draw(SharpDXRenderer renderer)
        {
            Vector2 location = this.GetAbsoluteLocation();
            if(this.MouseOver)
                renderer.FillRectangle(this.BackColor,
                    new Vector2(location.X - MarginLeft, location.Y - MarginTop),
                    new Vector2(this.Width + MarginLeft + MarginRight, this.Height + MarginTop + MarginBottom));
            
            base.Draw(renderer);
            
            renderer.DrawRectangle(this.ForeColor,
                new Vector2(location.X - MarginLeft, location.Y - MarginTop),
                new Vector2(this.Width + MarginLeft + MarginRight, this.Height + MarginTop + MarginBottom));
        }
    }
}
