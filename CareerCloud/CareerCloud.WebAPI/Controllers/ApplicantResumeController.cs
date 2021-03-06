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
    [Route("api/careercloud/applicant/v1")]
    [ApiController]
    public class ApplicantResumeController : ControllerBase
    {
        private readonly ApplicantResumeLogic _logic;

        public ApplicantResumeController()
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>();
            _logic = new ApplicantResumeLogic(repo);

        }
        [HttpGet]
        [Route("resume/{applicantResumeId}")]
        [ResponseType(typeof(ApplicantResumePoco))]
        public ActionResult GetApplicantResume(Guid ApplicantResumeId)
        {
            ApplicantResumePoco poco = _logic.Get(ApplicantResumeId);
            if (poco is null)
            {
                return NotFound();
            }
            return Ok(poco);
        }
        [HttpGet]
        [Route("resume")]
        [ResponseType(typeof(List<ApplicantResumePoco>))]
        public ActionResult GetAllApplicantResume()
        {
            List<ApplicantResumePoco> pocos = _logic.GetAll();
            if (pocos == null)
            {
                return NotFound();
            }
            return Ok(pocos);
        }

        [HttpPost]
        [Route("resume")]
        public ActionResult PostApplicantResume(
            [FromBody] ApplicantResumePoco[] pocos)
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
        [Route("resume")]
        public ActionResult PutApplicantResume(
            [FromBody] ApplicantResumePoco[] pocos)
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
        [Route("resume")]
        public ActionResult DeleteApplicantResume(
            [FromBody] ApplicantResumePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();

        }

    }
}
