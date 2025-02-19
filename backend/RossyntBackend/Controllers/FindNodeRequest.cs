﻿using System.ComponentModel.DataAnnotations;

#nullable enable

namespace RossyntBackend.Controllers {
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    public sealed class FindNodeRequest {
        [Required] public int Start { get; set; }
        [Required] public int End { get; set; }
    }
    // ReSharper restore UnusedAutoPropertyAccessor.Global
}
