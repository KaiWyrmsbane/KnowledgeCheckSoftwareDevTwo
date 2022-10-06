﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    //CreateApartmentClass
    internal class CreateApartment <T>: Building
    {
        public void ConstructBuildingType(Building building)
        {
                //Get materials
                var materialRepo = new MaterialsRepo();
                var materialsNeeded = materialRepo.GetMaterials();

                var permitRepo = new ZoningAndPermitRepo();

                var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

                if (buildingWasMade)
                {
                  Buildings.Add(building);
                }
        }
    }

    internal class Building: City 
    {
        //I want the construction to be inside the Building class
        public string Street { get; set; }

        public int StreetNumber { get; set; }

        
        //public void CreateApartment(Apartment apartment)
        //{
        //    // Get materials
        //    var materialRepo = new MaterialsRepo();
        //    var materialsNeeded = materialRepo.GetMaterials();

        //    var permitRepo = new ZoningAndPermitRepo();

        //    var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

        //    if (buildingWasMade)
        //    {
        //        Buildings.Add(apartment);
        //    }
        //}

        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T: Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
