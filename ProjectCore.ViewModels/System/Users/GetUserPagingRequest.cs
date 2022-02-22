using ProjectCore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}