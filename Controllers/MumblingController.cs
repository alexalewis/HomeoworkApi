using Microsoft.AspNetCore.Mvc;
using System;

namespace HomeoworkApi.Mumbling
{
  [Route("api/[controller]")]
  [ApiController]

  public class MumblingController : ControllerBase
  {
    [HttpGet("mumbling")]
    public string Accum(string s)
    {
      s = s.ToLower();

      var timesToRepeatTheLetter = 1;
      var answerString = "";
      // foreach letter in s
      foreach (var letter in s)
      {
        //.  repeat the letter timesToRepeatTheLetter times
        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        answerString += "-";
        timesToRepeatTheLetter++;
      }

      return answerString.TrimEnd('-');
    }
  }

}


