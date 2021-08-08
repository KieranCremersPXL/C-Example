using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirnessAppKieran.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Nutriments
    {
        public double carbohydrates { get; set; }
        public double sugars { get; set; }
        [JsonProperty("energy-kcal_100g")]
        public double EnergyKcal100g { get; set; }
        [JsonProperty("energy-kcal_value")]
        public double EnergyKcalValue { get; set; }
        public double energy_value { get; set; }
        public string sugars_unit { get; set; }
        public double proteins { get; set; }
        public double sodium { get; set; }
        public double energy_100g { get; set; }
        [JsonProperty("saturated-fat_100g")]
        public double SaturatedFat100g { get; set; }
        public double sugars_100g { get; set; }
        public double salt_100g { get; set; }
        public string fat_unit { get; set; }
        [JsonProperty("saturated-fat")]
        public double SaturatedFat { get; set; }
        [JsonProperty("saturated-fat_value")]
        public double SaturatedFatValue { get; set; }
        [JsonProperty("saturated-fat_unit")]
        public string SaturatedFatUnit { get; set; }
        public double carbohydrates_value { get; set; }
        public double carbohydrates_100g { get; set; }
        public double proteins_value { get; set; }
        public double energy { get; set; }
        public double sodium_100g { get; set; }
        [JsonProperty("energy-kcal")]
        public double EnergyKcal { get; set; }
        public double salt { get; set; }
        public string proteins_unit { get; set; }
        public double salt_value { get; set; }
        public string salt_unit { get; set; }
        public double sugars_value { get; set; }
        public double fat_100g { get; set; }
        public double proteins_100g { get; set; }
        [JsonProperty("energy-kcal_unit")]
        public string EnergyKcalUnit { get; set; }
        public double fat_value { get; set; }
        public double sodium_value { get; set; }
        public string carbohydrates_unit { get; set; }
        public string sodium_unit { get; set; }
        public string energy_unit { get; set; }
        public double fat { get; set; }
    }

    public class LanguagesCodes
    {
        public double fr { get; set; }
    }

    public class CategoriesProperties
    {
    }

    public class Languages
    {
        [JsonProperty("en:french")]
        public double EnFrench { get; set; }
    }

    public class NutrientLevels
    {
    }

    public class Small
    {
        public string fr { get; set; }
    }

    public class Thumb
    {
        public string fr { get; set; }
    }

    public class Display
    {
        public string fr { get; set; }
    }

    public class Front
    {
        public Small small { get; set; }
        public Thumb thumb { get; set; }
        public Display display { get; set; }
    }

    public class Nutrition
    {
        public Display display { get; set; }
        public Small small { get; set; }
        public Thumb thumb { get; set; }
    }

    public class SelectedImages
    {
        public Front front { get; set; }
        public Nutrition nutrition { get; set; }
    }

    public class _100
    {
        public double w { get; set; }
        public double h { get; set; }
    }

    public class Full
    {
        public double w { get; set; }
        public double h { get; set; }
    }

    public class _400
    {
        public double w { get; set; }
        public double h { get; set; }
    }

    public class Sizes
    {
        public _100 _100 { get; set; }
        public Full full { get; set; }
        public _400 _400 { get; set; }
        public _200 _200 { get; set; }
    }

    public class _1
    {
        public Sizes sizes { get; set; }
        public string uploader { get; set; }
        public double uploaded_t { get; set; }
    }

    public class _200
    {
        public double h { get; set; }
        public double w { get; set; }
    }

    public class FrontFr
    {
        public object normalize { get; set; }
        public string angle { get; set; }
        public string geometry { get; set; }
        public object white_magic { get; set; }
        public string y2 { get; set; }
        public string imgid { get; set; }
        public string x2 { get; set; }
        public Sizes sizes { get; set; }
        public string y1 { get; set; }
        public string rev { get; set; }
        public string x1 { get; set; }
    }

    public class NutritionFr
    {
        public string geometry { get; set; }
        public string angle { get; set; }
        public object normalize { get; set; }
        public string y2 { get; set; }
        public object white_magic { get; set; }
        public string x2 { get; set; }
        public string imgid { get; set; }
        public string x1 { get; set; }
        public string rev { get; set; }
        public string y1 { get; set; }
        public Sizes sizes { get; set; }
    }

    public class _2
    {
        public Sizes sizes { get; set; }
        public string uploader { get; set; }
        public double uploaded_t { get; set; }
    }

    public class Images
    {
        public _1 _1 { get; set; }
        public FrontFr front_fr { get; set; }
        public NutritionFr nutrition_fr { get; set; }
        public _2 _2 { get; set; }
    }

    public class Packaging
    {
        public string material { get; set; }
        public string shape { get; set; }
        public double ecoscore_shape_ratio { get; set; }
        public double ecoscore_material_score { get; set; }
    }

    public class Agribalyse
    {
    }

    public class Missing
    {
        public double categories { get; set; }
    }

    public class ThreatenedSpecies
    {
    }

    public class Packaging2
    {
        public string warning { get; set; }
        public double score { get; set; }
        public List<Packaging> packagings { get; set; }
        public double value { get; set; }
    }

    public class ProductionSystem
    {
    }

    public class AggregatedOrigin
    {
        public double percent { get; set; }
        public string origin { get; set; }
    }

    public class OriginsOfIngredients
    {
        public List<AggregatedOrigin> aggregated_origins { get; set; }
        public double epi_score { get; set; }
        public List<string> origins_from_origins_field { get; set; }
        public double epi_value { get; set; }
        public double transportation_value { get; set; }
        public double transportation_score { get; set; }
        public string warning { get; set; }
        public double value { get; set; }
    }

    public class Adjustments
    {
        public ThreatenedSpecies threatened_species { get; set; }
        public Packaging packaging { get; set; }
        public ProductionSystem production_system { get; set; }
        public OriginsOfIngredients origins_of_ingredients { get; set; }
    }

    public class EcoscoreData
    {
        public Agribalyse agribalyse { get; set; }
        public Missing missing { get; set; }
        public Adjustments adjustments { get; set; }
        public string status { get; set; }
    }

    public class CategoryProperties
    {
    }

    public class Product
    {
        public string origins_lc { get; set; }
        public List<object> nutrient_levels_tags { get; set; }
        public string link { get; set; }
        public List<object> ingredients_that_may_be_from_palm_oil_tags { get; set; }
        public Nutriments nutriments { get; set; }
        public List<object> categories_tags { get; set; }
        public string brands { get; set; }
        public List<string> data_quality_warnings_tags { get; set; }
        public string doubleerface_version_created { get; set; }
        public List<object> minerals_tags { get; set; }
        public double created_t { get; set; }
        public List<object> other_nutritional_substances_tags { get; set; }
        public List<string> pnns_groups_2_tags { get; set; }
        public string pnns_groups_1 { get; set; }
        public string expiration_date { get; set; }
        public List<object> amino_acids_tags { get; set; }
        public string ingredients_text { get; set; }
        public List<string> pnns_groups_1_tags { get; set; }
        public string ingredients_text_fr { get; set; }
        public LanguagesCodes languages_codes { get; set; }
        public List<object> origins_tags { get; set; }
        public List<string> nova_group_tags { get; set; }
        public List<string> categories_properties_tags { get; set; }
        public double unique_scans_n { get; set; }
        public string categories { get; set; }
        public string lang { get; set; }
        public string traces_from_user { get; set; }
        public string lc { get; set; }
        public CategoriesProperties categories_properties { get; set; }
        public string ingredients_text_with_allergens { get; set; }
        public string image_front_url { get; set; }
        public List<object> purchase_places_tags { get; set; }
        public List<string> debug_param_sorted_langs { get; set; }
        public List<string> ecoscore_tags { get; set; }
        public List<object> data_quality_bugs_tags { get; set; }
        public List<string> ciqual_food_name_tags { get; set; }
        public List<string> data_quality_tags { get; set; }
        public List<object> ingredients_from_palm_oil_tags { get; set; }
        public List<object> labels_tags { get; set; }
        public string image_front_thumb_url { get; set; }
        public string code { get; set; }
        public Languages languages { get; set; }
        public string allergens_lc { get; set; }
        public string data_sources { get; set; }
        public List<string> states_tags { get; set; }
        public string origins { get; set; }
        public string countries_lc { get; set; }
        public List<object> traces_tags { get; set; }
        public NutrientLevels nutrient_levels { get; set; }
        public List<object> ingredients_tags { get; set; }
        public List<string> data_quality_info_tags { get; set; }
        public SelectedImages selected_images { get; set; }
        public string categories_lc { get; set; }
        public Images images { get; set; }
        public List<string> states_hierarchy { get; set; }
        public List<Packaging> packagings { get; set; }
        public string stores { get; set; }
        public string labels { get; set; }
        public List<object> traces_hierarchy { get; set; }
        public double completeness { get; set; }
        public string image_nutrition_url { get; set; }
        public List<object> ingredients_hierarchy { get; set; }
        public string nutrition_data_per { get; set; }
        public EcoscoreData ecoscore_data { get; set; }
        public List<string> correctors_tags { get; set; }
        public string allergens_from_user { get; set; }
        public string image_nutrition_thumb_url { get; set; }
        public List<string> informers_tags { get; set; }
        public string origins_old { get; set; }
        public string manufacturing_places { get; set; }
        public List<object> additives_original_tags { get; set; }
        public List<object> ingredients_original_tags { get; set; }
        public string id { get; set; }
        public List<string> countries_tags { get; set; }
        public string creator { get; set; }
        public List<object> allergens_tags { get; set; }
        public double popularity_key { get; set; }
        public string traces { get; set; }
        public List<object> stores_tags { get; set; }
        public string allergens_from_ingredients { get; set; }
        public string nova_group_debug { get; set; }
        public string update_key { get; set; }
        public List<string> codes_tags { get; set; }
        public List<string> popularity_tags { get; set; }
        public List<object> ingredients { get; set; }
        public string states { get; set; }
        public List<object> labels_hierarchy { get; set; }
        public string traces_lc { get; set; }
        public string image_url { get; set; }
        public string product_name_fr { get; set; }
        public List<string> photographers_tags { get; set; }
        public string _id { get; set; }
        public double scans_n { get; set; }
        public string image_nutrition_small_url { get; set; }
        public string purchase_places { get; set; }
        public string image_small_url { get; set; }
        public List<object> origins_hierarchy { get; set; }
        public string last_modified_by { get; set; }
        public string traces_from_ingredients { get; set; }
        public string generic_name { get; set; }
        public List<string> last_edit_dates_tags { get; set; }
        public List<string> last_image_dates_tags { get; set; }
        public List<object> allergens_hierarchy { get; set; }
        public CategoryProperties category_properties { get; set; }
        public double rev { get; set; }
        public List<string> _keywords { get; set; }
        public List<object> unknown_nutrients_tags { get; set; }
        public double last_modified_t { get; set; }
        public string emb_codes { get; set; }
        public List<string> languages_hierarchy { get; set; }
        public List<string> editors_tags { get; set; }
        public List<object> additives_old_tags { get; set; }
        public List<object> cities_tags { get; set; }
        public string nutrition_data_prepared { get; set; }
        public string nutrition_data { get; set; }
        public string nutrition_score_debug { get; set; }
        public string quantity { get; set; }
        public string product_name { get; set; }
        public List<string> brands_tags { get; set; }
        public string allergens { get; set; }
        public List<string> data_sources_tags { get; set; }
        public double ingredients_percent_analysis { get; set; }
        public List<object> packaging_tags { get; set; }
        public List<object> nucleotides_tags { get; set; }
        public string image_front_small_url { get; set; }
        public List<object> data_quality_errors_tags { get; set; }
        public double sortkey { get; set; }
        public string max_imgid { get; set; }
        public List<string> languages_tags { get; set; }
        public string countries { get; set; }
        public string pnns_groups_2 { get; set; }
        public string generic_name_fr { get; set; }
        public double last_image_t { get; set; }
        public List<object> categories_hierarchy { get; set; }
        public string labels_lc { get; set; }
        public List<string> nutrition_grades_tags { get; set; }
        public List<object> vitamins_tags { get; set; }
        public string ingredients_text_with_allergens_fr { get; set; }
        public string nutrition_data_prepared_per { get; set; }
        public List<object> emb_codes_tags { get; set; }
        public string doubleerface_version_modified { get; set; }
        public List<object> checkers_tags { get; set; }
        public string no_nutrition_data { get; set; }
        public string image_thumb_url { get; set; }
        public List<string> entry_dates_tags { get; set; }
        public List<string> countries_hierarchy { get; set; }
        public string packaging { get; set; }
        public List<string> misc_tags { get; set; }
        public List<object> additives_tags { get; set; }
        public List<object> manufacturing_places_tags { get; set; }
        public string last_editor { get; set; }
        public double complete { get; set; }
    }

    public class Root
    {
        public string status_verbose { get; set; }
        public double status { get; set; }
        public Product product { get; set; }
        public string code { get; set; }
    }
    public class Food
	{
		public string image_front_small_url { get; set; }
		public string product_name { get; set; }
		public string allergens { get; set; }
		public double energy_value { get; set; }
	}
}
