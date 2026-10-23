using System;
using System.Text.RegularExpressions;

namespace CollectionsPart;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianNationalId(this string value)
    {
        string pattern = @"^[23]\d{13}$"; 
        if (string.IsNullOrWhiteSpace(value))
            return false;
        return Regex.IsMatch(value, pattern);       
    }

    public static bool IsValidEgyptianPhoneNumber(this string? value)
    {
        string pattern = @"^((010|011|012|015)\d{8}|\+20(10|11|12|15)\d{8})$";

        if (string.IsNullOrWhiteSpace(value))
            return false;
        
        return Regex.IsMatch(value, pattern);
            
    }
}
