﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HttpDoom.Shared.Records
{
    public record Options(
        List<string> Headers,
        [NotNull] string WordList,
        string Output,
        string ScreenshotResolution = "1920x1080",
        int MaxAllowedRedirect = 4,
        int Timeout = 4000,
        int Threads = 4,
        bool AllowAutomaticRedirect = true,
        bool Screenshot = false,
        bool IgnoreTls = true,
        bool Verbose = false,
        bool ShowDetails = false,
        bool Resolve = false
    )
    {
        public List<int> Ports { get; set; } = new();
    }
}