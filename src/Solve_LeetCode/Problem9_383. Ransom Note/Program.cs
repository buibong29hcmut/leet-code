bool CanConstruct(string ransomNote, string magazine)
{ 
    if (magazine.Contains(ransomNote))
        return true;
    if (magazine.Contains(new string(ransomNote.Reverse().ToArray())))
        return true;
    return false;
}


