﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX
{
    public class NotSupportedResponse : CFXMessage
    {
        public NotSupportedResponse()
        {
            RequestResult = new RequestResult()
            {
                Result = StatusResult.Success
            };
        }

        public RequestResult RequestResult
        {
            get;
            set;
        }
    }
}
