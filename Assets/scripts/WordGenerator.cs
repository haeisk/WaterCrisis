using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    public static string[]wordlist = {
     "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", 
    "elif", "else", "except", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", 
    "not", "or", "pass", "raise", "return", "try", "while", "with", "yield", "int", "float", "str", "list", "tuple", 
    "set", "dict", "bool", "bytes", "bytearray", "memoryview", "frozenset", "complex", "range", "open", "print", 
    "input", "len", "type", "id", "sorted", "sum", "min", "max", "abs", "pow", "round", "divmod", "enumerate", 
    "filter", "map", "zip", "all", "any", "chr", "ord", "bin", "oct", "hex", "format", "help", "dir", "vars", 
    "hasattr", "getattr", "setattr", "delattr", "property", "issubclass", "isinstance", "super", "staticmethod", 
    "classmethod"
    }; 


    public static string GetRandomWord(){
        int index = Random.Range(0,wordlist.Length);
        string randomWord = wordlist[index];
        return randomWord;

    }
}
