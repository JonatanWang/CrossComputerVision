using System;

namespace CrossComputerVision.Models {

    public class ImageData
    {

        public int Id { get; set; }
        public string ImageName { get; set; }
        public string AnalysisResult { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
