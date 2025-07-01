using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InfraPricingCalculator.Models;
using InfraPricingCalculator.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace infra_pricing_calculator.Pages
{
    public class CalculadoraModel : PageModel
    {
        [BindProperty]
        public ResourceConfig Config { get; set; } = new ResourceConfig();

        public List<CostCalculator.ItemCost> ItemCosts { get; set; }
        public decimal TotalCost { get; set; }

        public void OnGet()
        {
            // Inicializa con un módulo de cada tipo por defecto
            if (Config.VMs.Count == 0) Config.VMs.Add(new VMItem { VMType = "Standard", VMCount = 1 });
            if (Config.Databases.Count == 0) Config.Databases.Add(new DatabaseItem { DatabaseType = "SQL", DatabaseCount = 1 });
            if (Config.Storages.Count == 0) Config.Storages.Add(new StorageItem { StorageType = "SSD", StorageSizeGB = 100 });

            var calc = new CostCalculator();
            var result = calc.Calculate(Config);
            ItemCosts = result.ItemCosts;
            TotalCost = result.Total;
        }

        public void OnPost()
        {
            var calc = new CostCalculator();
            var result = calc.Calculate(Config);
            ItemCosts = result.ItemCosts;
            TotalCost = result.Total;
        }

        public IActionResult OnPostCalcularAjax()
        {
            var calc = new CostCalculator();
            var result = calc.Calculate(Config);
            ItemCosts = result.ItemCosts;
            TotalCost = result.Total;

            return Partial("_CostDetails", this);
        }
    }
}
