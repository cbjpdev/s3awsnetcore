﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeBackup.Core.Communication.Files
{
    public class AddFileResponse
    {
        public IList<string> PreSignedUrl { get; set; }
    }
}
