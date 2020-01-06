﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sample_dotnetcore_webapi_ef_services.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public bool Read { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}
