﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElementEngine.ElementUI
{
    public class UISpriteStatic : UISprite
    {
        public UITexture Texture;

        public UISpriteStatic(string assetName)
            : this(new UITexture(AssetManager.Instance.LoadTexture2D(assetName)))
        {
        }

        public UISpriteStatic(UITexture texture)
        {
            Texture = texture;
            Size = Texture.SourceRect.Size;
        }

        public override void Draw(UIObject parent, SpriteBatch2D spriteBatch, Vector2I position, Vector2I? size = null, float rotation = 0f)
        {
            Texture.Draw(spriteBatch, GetDrawPosition(parent, position, IgnoreSize ? Size : (size ?? Size)).ToVector2(), IgnoreSize ? Vector2.One : Texture.GetScale(size), rotation);
        }
    }
}
