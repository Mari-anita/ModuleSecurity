﻿using Entity.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface IPersonController
    {
        public Task<ActionResult<IEnumerable<PersonDto>>> GetAll();

        public Task<ActionResult<PersonDto>> Save([FromBody] PersonDto personDto);

        public Task<IActionResult> Update([FromBody] PersonDto personDto);

        public Task<IActionResult> Delete(int id);
    }
}
