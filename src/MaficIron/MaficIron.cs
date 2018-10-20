using Harmony;
using System.Collections.Generic;

namespace MaficIron
{
    [HarmonyPatch(typeof(MetalRefineryConfig))]
    [HarmonyPatch("ConfigureBuildingTemplate")]
    public static class RefineryMaficIronMod
	{
		public static void Postfix()
		{
			ComplexRecipe.RecipeElement recipeElement1 = new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.MaficRock).tag, 100f);
			ComplexRecipe.RecipeElement recipeElement2 = new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Regolith).tag, 100f);
			ComplexRecipe.RecipeElement recipeElement3 = new ComplexRecipe.RecipeElement(ElementLoader.FindElementByHash(SimHashes.Iron).tag, 100f);

			ComplexRecipe.RecipeElement[] ingredients1 = new ComplexRecipe.RecipeElement[2] { recipeElement1, recipeElement2 };
			ComplexRecipe.RecipeElement[] results1 = new ComplexRecipe.RecipeElement[1] { recipeElement3 };
			string str1 = ComplexRecipeManager.MakeRecipeID("MetalRefinery", ingredients1, results1);
			new ComplexRecipe(str1, ingredients1, results1)
			{
				time = 0f,
				useResultAsDescription = true,
				description = string.Format("Produces {0} from {1} and {2}", ElementLoader.GetElement(recipeElement3.material).name, ElementLoader.GetElement(recipeElement1.material).name, ElementLoader.GetElement(recipeElement2.material).name)
			}.fabricators = new List<Tag>(){TagManager.Create("MetalRefinery")};
        }
	}
}
