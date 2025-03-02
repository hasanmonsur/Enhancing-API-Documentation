using Microsoft.AspNetCore.Mvc;

namespace SwaggerWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Retrieves all users from the system.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of users.
        /// </remarks>
        /// <returns>A list of users</returns>
        /// <response code="200">Returns the list of users</response>
        /// <response code="500">If an internal error occurs</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetUsers()
        {
            var users = new List<string> { "Alice", "Bob", "Charlie" };
            return Ok(users);
        }

        /// <summary>
        /// Retrieves a specific user by ID.
        /// </summary>
        /// <param name="id">The user ID</param>
        /// <returns>The user details</returns>
        /// <response code="200">Returns the user details</response>
        /// <response code="404">If the user is not found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var user = new { Id = id, Name = "Alice" };
            return Ok(user);
        }
    }
}
