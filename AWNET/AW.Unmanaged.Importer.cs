using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace AW
{
    internal class Importer
    {
        #region Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void Event();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void Callback(int rc);
        #endregion

        #region Original methods
        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_init(int build);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_init_bind(int build, uint addr);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern void aw_term();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_create(string domain, int port, out IntPtr instance);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_create_resolved(uint address, int port, out IntPtr instance);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_destroy();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern IntPtr aw_instance();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_instance_set(IntPtr instance);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_login();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_wait(int milliseconds);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_int(Attributes a);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_int_set(Attributes a, int value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern IntPtr aw_string(Attributes a);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_string_set(Attributes a, string value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_bool(Attributes a);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_bool_set(Attributes a, bool value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern float aw_float(Attributes a);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_float_set(Attributes a, float value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern IntPtr aw_data(Attributes a, out uint length);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_data_set(Attributes a, IntPtr value, uint length);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern Callback aw_callback(AW_CALLBACK c);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_callback_set(AW_CALLBACK c, Callback cb);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_instance_callback_set(AW_CALLBACK c, Callback cb);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern Event aw_event(AW_EVENT a);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_event_set(AW_EVENT a, Event ev);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_instance_event_set(AW_EVENT a, Event ev);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_enter(string world);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_exit();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_say(string message);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_whisper(int session_id, string message);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_state_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_attributes_by_name(string name);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_attributes_by_number(int citizen);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_delete(int citizen);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_citizen_previous();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_attributes(string name);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_delete(string name);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_license_previous();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_list();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_delete();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_load();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_query(int x_sector, int z_sector, int[,] sequence);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_query_5x5(int x_sector, int z_sector, int[,] sequence);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_random();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_attributes_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_attributes_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_session();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_eject();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_sector_from_cell(int cell);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_ejection_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_ejection_delete(int address);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_ejection_lookup();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_ejection_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_universe_ejection_previous();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_click();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_select();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_avatar_click(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_address(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_url_send(int session_id, string url, string target);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_url_click(string url);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_teleport(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_ejection_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_ejection_delete();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_ejection_lookup();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_ejection_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_ejection_previous();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_attribute_set(int attribute, string value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_attribute_get(int attribute, out int read_only, string value);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_delete_all_objects();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_cell_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_reload_registry();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_attributes_reset();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_terrain_set(int x, int z, int count, int texture, int[] heights);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_terrain_query(int page_x, int page_z, ulong sequence);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_terrain_next();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_terrain_delete_all();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_terrain_load_node();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_console_message(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_avatar_set(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_avatar_reload(int citizen, int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_instance_set(int citizen, int world_instance);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_instance_get(int citizen);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_botgram_send();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_toolbar_click();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_user_list();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_noise(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_attributes_send(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_camera_set(int session_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_botmenu_send();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_bump();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_traffic_count(out int traffic_in, out int traffic_out);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern uint aw_tick();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern bool aw_check_right(int citizen, string str);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern bool aw_check_right_all(string str);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern bool aw_has_world_right(int citizen, Attributes right);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern bool aw_has_world_right_all(Attributes right);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_set_state(int id, int state, int model_num);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_set_position(int id, int x, int y, int z, int yaw, int pitch, int roll);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_rider_add(int id, int session, int dist, int angle, int y_delta, int yaw_delta, int pitch_delta);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_rider_change(int id, int session, int dist, int angle, int y_delta, int yaw_delta, int pitch_delta);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_rider_delete(int id, int session);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_mover_links(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_admin(string domain, int port, string password, out IntPtr instance);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_add();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_delete(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_change(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_list();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_start(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_stop(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_set(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_instance_set(int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_instance_add(int id, int instance_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_server_world_instance_delete(int id, int instance_id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_avatar_location(int citizen, int session_id, string name);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_hud_create();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_hud_click();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_hud_destroy(int session, int id);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_hud_clear(int session);

        #endregion

        #region Build 70 additions
        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_cav_request(int citizen, int session);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_cav_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_cav_delete();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_cav_request(int citizen, int session);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_cav_change();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_world_cav_delete();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_object_query();

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_zip(IntPtr data_out, out uint len_out, IntPtr data_in, uint len_in);

        [DllImport("aw", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern int aw_unzip(IntPtr data_out, out uint len_out, IntPtr data_in, uint len_in);

        #endregion

    }
}
