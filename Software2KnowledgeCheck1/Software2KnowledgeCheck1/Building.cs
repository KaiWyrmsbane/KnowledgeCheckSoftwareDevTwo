using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Building: City
    {
        //I want the construction to be inside the Building class
        public string Street { get; set; }

        public int StreetNumber { get; set; }
        private City _city = new City();
        public Building(City city)
        {
            _city = city;
        }
        
        public void ConstructBuildingType <T> (T building)
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
            switch (building)
            {
                case (typeof(T) == typeof(Apartment)):
                    var buidlingCreated = ConstructBuilding<HighRise>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());
                    _city.Buildings.Add(buidlingCreated);
                    break;
                case (typeof(T) == typeof(HighRise)):
                    var buildingCreated = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());
                    _city.Buildings.Add(HighRise);
                    break;
            }
        }

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

 