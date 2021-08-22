using H.LowCode.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H.LowCode.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public FormModel Get(string id)
        {
            return new FormModel();
        }

        [HttpPost]
        public void Save(string jsonData)
        {
            //JSchema jSchema = new JSchema();
            //JsonSchemaHelper.ValidateJsonSchema(jsonSchema, jsonData);
        }
    }
}
