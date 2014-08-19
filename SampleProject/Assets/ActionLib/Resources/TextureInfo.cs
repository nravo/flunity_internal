using UnityEngine;

namespace ActionLib.Resources
{
	internal struct TextureInfo
	{
		public Texture2D texture;
		public float scale;

		public TextureInfo(Texture2D texture, float scale)
		{
			this.texture = texture;
			this.scale = scale;
		}
	}
}
