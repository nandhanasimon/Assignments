﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/system/v1")]
    [ApiController]
    public class SystemLanguageCodeController : ControllerBase
    {
        private readonly SystemLanguageCodeLogic _logic;
        public SystemLanguageCodeController()
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>();
            _logic = new SystemLanguageCodeLogic(repo);
        }
        [HttpGet]
        [Route("languagecode/{systemLanguageCodeId}")]
        [ResponseType(typeof(SystemLanguageCodePoco))]

        public ActionResult GetSystemLanguageCode(string SystemLanguageCodeId)
        {
            SystemLanguageCodePoco poco = _logic.Get(SystemLanguageCodeId);
            if (poco is null)
            {
                return NotFound();
            }
            return Ok(poco);
        }
        [HttpGet]
        [Route("languagecode")]
        [ResponseType(typeof(List<SystemLanguageCodePoco>))]
        public ActionResult GetAllSystemLanguageCode()
        {
            List<SystemLanguageCodePoco> pocos = _logic.GetAll();
            if (pocos == null)
            {
                return NotFound();
            }
            return Ok(pocos);
        }

        [HttpPost]
        [Route("languagecode")]
        public ActionResult PostSystemLanguageCode(
            [FromBody] SystemLanguageCodePoco[] pocos)
        {
            try
            {
                _logic.Add(pocos);
                return Ok();
            }
            catch (AggregateException a)
            {
                return BadRequest(a);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
        [HttpPut]
        [Route("languagecode")]
        public ActionResult PutSystemLanguageCode(
            [FromBody] SystemLanguageCodePoco[] pocos)
        {
            try
            {
                _logic.Update(pocos);
                return Ok();
            }
            catch (AggregateException a)
            {
                return BadRequest(a);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete]
        [Route("languagecode")]
        public ActionResult DeleteSystemLanguageCode(
            [FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();

        }

    }
}
