﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossout.Data
{
    public class PartStats
    {
        public PartStats()
        {

        }

        public PartStats(string key)
        {
            this.Key = key;
        }

        public void CreateStatList()
        {
            
        }

        public Dictionary<string,SingleStat> Stats { get; } = new Dictionary<string, SingleStat>();
        public List<SingleStat> SortedStats { get; } = new List<SingleStat>();

        public void LoadAttributes()
        {
            Stats.Clear();
            SortedStats.Clear();

            var properties = this.GetType().GetProperties();
            foreach (var p in properties)
            {
                var attributes = p.GetCustomAttributes(typeof(StatAttribute),false);
                if (attributes.Length > 0)
                {
                    var statAttrib = (StatAttribute) attributes[0];
                    if (!Stats.ContainsKey(p.Name))
                    {
                        Stats[p.Name] = new SingleStat {Key = p.Name, Stat = statAttrib, Value = p.GetValue(this)};
                    }
                }
            }

            var sortedStats = Stats.Values.OrderBy(x => x.Stat.Order);
            SortedStats.AddRange(sortedStats);
        }

        public string Key { get; set; }

        // Crossout Properties
        public bool ods_export { get; set; }
        
        public string inherit { get; set; }
        public bool released { get; set; }
        public bool tradeable { get; set; }
        public string item_type { get; set; }
        public string model { get; set; }
        public string subtype { get; set; }
        public string editor_type { get; set; }
        public string taglist { get; set; }
        public string ui_part_type_icon { get; set; }
        public string ui_part_filter { get; set; }
        public string ui_part_series { get; set; }
        public string ui_part_type { get; set; }
        public string ui_hud_icon { get; set; }

        [Stat("Health", 0)]
        public double health { get; set; }
        public bool damageable { get; set; }
        public int rarity { get; set; }
        public int power_require { get; set; }
        public string @class { get; set; }
        public double fire_rate { get; set; }

        [Stat("Damage", 1)]
        public double damage { get; set; }
        public double hit_impulse { get; set; }
        public double rot_speed { get; set; }

        [Stat("Optimal Range", 2)]
        public double optimal_range { get; set; }

        [Stat("Max Range", 3)]
        public double max_range { get; set; }
        public double ai_optimal_dist { get; set; }
        public double spread_stat { get; set; }
        public double spread_stat_max { get; set; }
        public double spread_move { get; set; }
        public double spread_move_max { get; set; }
        public double spread_inc { get; set; }
        public double spread_dec { get; set; }
        public double spread_rot_inc { get; set; }
        public string projectile { get; set; }
        public int max_pitch { get; set; }
        public int min_pitch { get; set; }

        public double damage_rating { get; set; }

        [Stat("Fire Rating", 5)]
        public double fire_rate_rating { get; set; }

        [Stat("Range Rating", 6)]
        public double range_rating { get; set; }

        [Stat("Accuracy Rating", 7)]
        public double accuracy_rating { get; set; }

        [Stat("Overheat Rating", 8)]
        public double overheat_rating { get; set; }

        [Stat("Power Score", -100)]
        public int universal_rating { get; set; }
        public bool important { get; set; }
        public int heat_max { get; set; }
        public double heat_inc { get; set; }
        public double heat_dec { get; set; }
        public string damage_perk { get; set; }
        public int require_faction_level { get; set; }
        public double reward_Scrap_Common { get; set; }
        public double reward_Scrap_Rare { get; set; }
        public double reward_Scrap_Epic { get; set; }
        public bool salvageable { get; set; }
        public int salvage_Scrap_Common_min { get; set; }
        public int salvage_Scrap_Common_max { get; set; }
        public int salvage_Spares_Common_min { get; set; }
        public int salvage_Spares_Common_max { get; set; }
        public int salvage_Scrap_Rare_min { get; set; }
        public int salvage_Scrap_Rare_max { get; set; }
        public int salvage_Spares_Rare_min { get; set; }
        public int salvage_Spares_Rare_max { get; set; }
        public int salvage_Scrap_Epic_min { get; set; }
        public int salvage_Scrap_Epic_max { get; set; }
        public int salvage_Spares_Epic_min { get; set; }
        public int salvage_Spares_Epic_max { get; set; }
        public int salvage_Spares_Legendary_min { get; set; }
        public int salvage_Spares_Legendary_max { get; set; }
        public int salvage_Spares_Exotic_min { get; set; }
        public int salvage_Spares_Exotic_max { get; set; }
        public string fusion { get; set; }
        public string fusion_cost { get; set; }
        public string perk { get; set; }
        public string require_faction { get; set; }
        public double recoil_impulse { get; set; }
        public double speedup_time { get; set; }
        public double slowdown_time { get; set; }
        public int max_yaw { get; set; }
        public int min_yaw { get; set; }
        public string ui_aim_type { get; set; }
        public double blast_damage { get; set; }
        public double blast_impulse { get; set; }
        public double blast_radius { get; set; }
        public bool sniper_weapon { get; set; }
        public int projectile_speed { get; set; }
        public double projectile_damping { get; set; }
        public int ammo { get; set; }
        public int ammo_refill { get; set; }
        public double magic_find { get; set; }
        public int pellet_count { get; set; }
        public double spread_scale_x { get; set; }
        public double spread_scale_y { get; set; }
        public bool secondary_weapon { get; set; }
        public double shooting_cooldown { get; set; }
        public bool conical_explosion { get; set; }
        public bool editor_horizontal_rotation { get; set; }
        public double projectile_detonation_radius { get; set; }
        public double projectile_launch_angle { get; set; }
        public double projectile_ttl { get; set; }
        public int burst_size { get; set; }
        public int projectile_rot_radius { get; set; }
        public bool fixed_barrel { get; set; }
        public double lock_angle { get; set; }
        public bool check_restriction_overlap { get; set; }
        public bool damage_type_flame { get; set; }
        public double death_blast_damage { get; set; }
        public double death_blast_radius { get; set; }
        public string platform_exclusive { get; set; }
        public double charging_time { get; set; }
        public bool big_explosion { get; set; }
        public bool ai_ignore_pitch { get; set; }
        public int projectile_slowdown_pitch { get; set; }
        public double projectile_slowdown_pitch_coef { get; set; }
        public double gravity_multiplyer { get; set; }
        public int car_camera_correction_y { get; set; }
        public string target_area_effect { get; set; }
        public double pitch_coef { get; set; }
        public int zero_pitch { get; set; }
        public int heavy_unique_count { get; set; }
        public int dodge_angular_acceleration { get; set; }
        public int projectile_phase2_time { get; set; }
        public bool innate_ai { get; set; }
        public bool charging_need_hold { get; set; }
        public bool fire_without_target { get; set; }
        public double barrel_detonation_radius { get; set; }
        public int innate_ai_cooldown_time { get; set; }
        public int innate_ai_work_time { get; set; }
        public int projectile_angular_speed { get; set; }
        public int slow_fire_rate { get; set; }
        

        // Custom Properties
        [Stat("Damage Rating", 4)]
        public double PercentDamage
        {
            get { return damage_rating*100.0f; }
        }
    }
}
