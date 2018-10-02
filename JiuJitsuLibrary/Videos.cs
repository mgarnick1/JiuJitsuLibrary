using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JiuJitsuLibrary
{
	public class Videos
	{
		public Videos()
		{

		}
		private int videoNumber;

		public int VideoNumber
		{
			get { return videoNumber; }
			set { videoNumber = value; }
		}
		private string videoName;

		public string VideoName
		{
			get { return videoName; }
			set { videoName = value; }
		}

		private FileInfo filePath;

		public FileInfo FilePath
		{
			get { return filePath; }
			set { filePath = value; }
		}
		private string skillLevel;

		public string SkillLevel
		{
			get { return skillLevel; }
			set { skillLevel = value; }
		}



	}
}
