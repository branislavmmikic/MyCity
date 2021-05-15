using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bot_backEnd.UI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bot_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationUI _iNotificationUI;
        public NotificationController(INotificationUI iNotificationUI)
        {
            _iNotificationUI = iNotificationUI;
        }

        [Authorize(Roles = "User")]
        [HttpGet("{userEntityId}")]
        public IActionResult GetNotificationsByUserID(int userEntityID)
        {
            try
            {
                return Ok(_iNotificationUI.GetAllNotificationsByUserID(userEntityID));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}