using System.Text;

namespace BlzrorWebBookApp.Data
{
	public class NullCheck
	{
		readonly int _maxContent = 250;
		readonly StringBuilder _sb = new();
		public string IfImageIsNull(string? imageURL)
		{
			if (imageURL is null)
			{
				return "/images/no_image_square.jpg";
			}
			return imageURL;
		}
		public bool IsAuthorFirstIndexIsNull(IEnumerable<string>? authors) => authors is null;
		public string PreviewLengthGreaterThanMaxContent(string? description)
		{

			if (description is null)
				return "";
			_sb.Clear();
			if (description.Length > _maxContent)
			{
				_sb.Append(description.Substring(0, _maxContent));
				_sb.Append("...");
				return _sb.ToString();
			}
			return description;
		}
	}
}
