
using System;

namespace dixseptManagement.Request
{
    // フロント側のRequestのモデルと名前を一致させる
    public class PlayerRequest : RequestBase
    {
        public string imageName { get; set; }

        public string imageData { get; set; }

        public int uniformNumber { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public string lastNameEn { get; set; }

        public string firstNameEn { get; set; }

        public string birthdayPlace { get; set; }

        public DateTime birthday { get; set; }

        public string positionCd { get; set; }

        public int weight { get; set; }

        public int height { get; set; }

        public string comment { get; set; }
    }
}
