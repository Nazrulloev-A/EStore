using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    public class BuggyController :BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound(){
            return NotFound();
        }

         [HttpGet("bad-request")]
        public ActionResult GetBadRequest(){
            return BadRequest(new ProblemDetails{Title="This is a bad request"});
        }

         [HttpGet("unauthorized")]
        public ActionResult GetUnauthorised(){
            return Unauthorized();
        }

         [HttpGet("validation-error")]
        public ActionResult GetValidationError(){
            ModelState.AddModelError("P1", "1-ERROR");
            ModelState.AddModelError("P2","2_ERROR");
            return ValidationProblem();
        }

         [HttpGet("server-error")]
        public ActionResult GetServerError(){
            throw new Exception("This is a server error");
        }

    }
