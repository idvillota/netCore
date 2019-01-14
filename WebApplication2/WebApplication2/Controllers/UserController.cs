using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Extensions;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication2.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public UserController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper)
        {
            _logger = loggerManager;
            _repository = repositoryWrapper;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _repository.User.GetAllUsers();

                _logger.LogInfo($"Returned all users from database.");
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllUsers action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "UserById")]
        public IActionResult GetUserById(decimal id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);

                if (user.IsEmptyObject())
                {
                    _logger.LogError($"User with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned user with id: {id}");
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetUserById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody]User user)
        {
            try
            {
                if(user.IsObjectNull())
                {
                    _logger.LogError($"User object sent from client is null.");
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid user object sent from client");
                    return BadRequest($"Invalid model object");
                }

                _repository.User.CrearUser(user);

                return CreatedAtRoute("UserById", new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(decimal id, [FromBody]User user)
        {
            try
            {
                if (user.IsObjectNull())
                {
                    _logger.LogError($"User object sent from client is null.");
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid user object sent from client.");
                    return BadRequest($"Invalid model object");
                }

                var dbUser = _repository.User.GetUserById(id);
                if (dbUser.IsEmptyObject())
                {
                    _logger.LogError($"User with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _repository.User.UpdateUser(dbUser, user);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(decimal id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);
                if (user.IsEmptyObject())
                {
                    _logger.LogError($"User with id: {id}, hasn't been found in db");
                    return NotFound();
                }

                _repository.User.DeleteUser(user);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        //[HttpGet("{id}/account")]
        //public IActionResult GetOwnerWithDetails(Guid id)
        //{
        //    try
        //    {
        //        var owner = _repository.Owner.GetOwnerWithDetails(id);

        //        if (owner.Id.Equals(Guid.Empty))
        //        {
        //            _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
        //            return NotFound();
        //        }
        //        else
        //        {
        //            _logger.LogInfo($"Returned owner with details for id: {id}");
        //            return Ok(owner);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside GetOwnerWithDetails action: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

    }
}
