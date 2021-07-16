using F23.StringSimilarity;
using Microsoft.AspNetCore.Mvc;
using NameComparator.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NameComparator.Controllers
{
    [Route("apicf")]
    [ApiController]
    public class NameComparatorController : ControllerBase
    {
        /// <summary>
        /// Levenshtein distance
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("levenshtein")]
        public ActionResult<ComparisonResult> GetLevenshtein([FromForm] InputStringDetails input)
        {
            var l = new Levenshtein();
            return Ok(new ComparisonResult(input, l.Distance(input.Name1, input.Name2)));
        }

        /// <summary>
        /// Normalized Levenshtein
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("normalizedlevenshtein")]
        public ActionResult<ComparisonResult> GetNormalizedLevenshtein([FromForm] InputStringDetails input)
        {
            var l = new NormalizedLevenshtein();
            return Ok(new ComparisonResult(input, l.Distance(input.Name1, input.Name2)));
        }

        /// <summary>
        /// Jaro-Winkler
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("jarowinkler")]
        public ActionResult<ComparisonResult> GetJaroWinkler([FromForm] InputStringDetails input)
        {
            var l = new JaroWinkler();
            return Ok(new ComparisonResult(input, l.Similarity(input.Name1, input.Name2)));
        }

    }
}
