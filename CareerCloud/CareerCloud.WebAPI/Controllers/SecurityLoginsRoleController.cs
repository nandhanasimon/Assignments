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
    [Route("api/careercloud/security/v1")]
    [ApiController]
    public class SecurityLoginsRoleController : ControllerBase
    {
        private readonly SecurityLoginsRoleLogic _logic;
        public SecurityLoginsRoleController()
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>();
            _logic = new SecurityLoginsRoleLogic(repo);
        }
        [HttpGet]
        [Route("loginsrole/{securityLoginsRoleId}")]
        [ResponseType(typeof(SecurityLoginsRolePoco))]

        public ActionResult GetSecurityLoginsRole(Guid SecurityLoginsRoleId)
        {
            SecurityLoginsRolePoco poco = _logic.Get(SecurityLoginsRoleId);
            if (poco is null)
            {
                return NotFound();
            }
            return Ok(poco);
        }
        [HttpGet]
        [Route("loginsrole")]
        [ResponseType(typeof(List<SecurityLoginsRolePoco>))]
        public ActionResult GetAllSecurityLoginsRole()
        {
            List<SecurityLoginsRolePoco> pocos = _logic.GetAll();
            if (pocos == null)
            {
                return NotFound();
            }
            return Ok(pocos);
        }

        [HttpPost]
        [Route("loginsrole")]
        public ActionResult PostSecurityLoginRole(
            [FromBody] SecurityLoginsRolePoco[] pocos)
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
        [Route("loginsrole")]
        public ActionResult PutSecurityLoginsRole(
            [FromBody] SecurityLoginsRolePoco[] pocos)
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
        [Route("loginsrole")]
        public ActionResult DeleteSecurityLoginRole(
            [FromBody] SecurityLoginsRolePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();

        }

    }
}
