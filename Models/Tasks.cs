﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GL_dotnet_training.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int Status { get; set; }
        public int AssignedToUserID { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
