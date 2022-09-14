﻿using Microsoft.AspNetCore.Mvc;

namespace Retribusi.Helpers;

public static class Result
{
    [Produces("application/json")]
    public static Dictionary<string, bool> Success()
    {
        var result = new Dictionary<string, bool>();
        result.Add("success", true);
        return result;
    }
}