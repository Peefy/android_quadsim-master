using System;
using UnityEngine;

[Serializable]
public class Alt_hold_button : MonoBehaviour
{
	public Transform Quad;

	public Transform butt_off;

	private int height_pos;

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Flying_Mode") == 2 || PlayerPrefs.GetInt("Flying_Mode") == 3)
		{
			this.transform.gameObject.SetActive(false);
			this.butt_off.gameObject.SetActive(false);
		}
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f + this.guiTexture.pixelInset.height * 1.25f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (!((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold)
		{
			int num = 0;
			Color color = this.guiTexture.color;
			float num2 = color.a = (float)num;
			Color color2 = this.guiTexture.color = color;
			float a = 0.5f;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = a;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		if (((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold)
		{
			float a2 = 0.5f;
			Color color5 = this.guiTexture.color;
			float num4 = color5.a = a2;
			Color color6 = this.guiTexture.color = color5;
			int num5 = 0;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = (float)num5;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_hold();
				}
			}
		}
		if (Input.GetButtonDown("Hold"))
		{
			this.execute_hold();
		}
	}

	public override void execute_hold()
	{
		((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).level_flight = this.Quad.transform.position.y;
		((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold = !((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold;
	}

	public override void Main()
	{
	}
}

using System;

internal class <Module>
{
}

using System;
using UnityEngine;

[Serializable]
public class Acc_button : MonoBehaviour
{
	public Transform Cam_human_cont;

	public Transform butt_off;

	public Transform current_cam;

	private int camera_selected;

	private int mode_sel;

	private int height_pos;

	public override void Start()
	{
		this.mode_sel = PlayerPrefs.GetInt("Input_mode");
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)(this.guiTexture.pixelInset.height * 0.625f);
		int num5 = 20;
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num6 = pixelInset5.x = (float)num5;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		float y = (float)Screen.height * 0.5f - (float)this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = y;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		int num8 = 20;
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num9 = pixelInset7.x = (float)num8;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		float y2 = (float)Screen.height * 0.5f - (float)this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = y2;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		this.camera_selected = ((Camera_GUI_Change_button)this.current_cam.GetComponent(typeof(Camera_GUI_Change_button))).cam_sel;
		if (this.camera_selected > 0 || this.mode_sel == 5)
		{
			this.butt_off.transform.guiTexture.enabled = false;
			this.transform.guiTexture.enabled = false;
		}
		else
		{
			this.butt_off.transform.guiTexture.enabled = true;
			this.transform.guiTexture.enabled = true;
		}
		if (!((Move_Human_Cam)this.Cam_human_cont.GetComponent(typeof(Move_Human_Cam))).acc_move)
		{
			int num = 0;
			Color color = this.guiTexture.color;
			float num2 = color.a = (float)num;
			Color color2 = this.guiTexture.color = color;
			float a = 0.5f;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = a;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		if (((Move_Human_Cam)this.Cam_human_cont.GetComponent(typeof(Move_Human_Cam))).acc_move)
		{
			float a2 = 0.5f;
			Color color5 = this.guiTexture.color;
			float num4 = color5.a = a2;
			Color color6 = this.guiTexture.color = color5;
			int num5 = 0;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = (float)num5;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_move();
				}
			}
		}
		if (Input.GetButtonDown("Move"))
		{
			this.execute_move();
		}
	}

	public override void execute_move()
	{
		((Move_Human_Cam)this.Cam_human_cont.GetComponent(typeof(Move_Human_Cam))).acc_move = !((Move_Human_Cam)this.Cam_human_cont.GetComponent(typeof(Move_Human_Cam))).acc_move;
	}

	public override void Main()
	{
	}
}

using Boo.Lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class advertise : MonoBehaviour
{
	[CompilerGenerated]
	[Serializable]
	internal sealed class $load_texture$727 : GenericGenerator<WWW>
	{
		internal advertise $self_$732;

		public $load_texture$727(advertise self_)
		{
			this.$self_$732 = self_;
		}

		public override IEnumerator<WWW> GetEnumerator()
		{
			return new advertise.$load_texture$727.$(this.$self_$732);
		}
	}

	public string url;

	public string url_text;

	public string url_version;

	public Transform adv_display;

	public Texture texture_image;

	public string[] text_string;

	public bool once;

	public bool display_default;

	public Transform Quadcopter_defaults;

	private int random_int;

	private int start_time;

	private bool timeout;

	public override void Start()
	{
		this.url = "http://www.3dcreativeworld.com/QCFX/Advertise.png";
		this.url_text = "http://www.3dcreativeworld.com/QCFX/url.txt";
		this.start_time = (int)Time.time;
		if (((Setting_up_defaults)this.Quadcopter_defaults.GetComponent(typeof(Setting_up_defaults))).ispro)
		{
			this.random_int = UnityEngine.Random.Range(1, PlayerPrefs.GetInt("Random_times_adv_ispro"));
		}
		else
		{
			this.random_int = UnityEngine.Random.Range(1, PlayerPrefs.GetInt("Random_times_adv"));
		}
	}

	public override void LateUpdate()
	{
		if (!this.once && this.random_int == 1)
		{
			this.StartCoroutine("load_texture");
			this.once = true;
		}
		else if (!((Setting_up_defaults)this.Quadcopter_defaults.GetComponent(typeof(Setting_up_defaults))).ispro && this.random_int != 1 && !this.once && PlayerPrefs.GetInt("Pro_Text_Show") != 1)
		{
			int num = UnityEngine.Random.Range(1, 4);
			if (num == 1)
			{
				this.display_default = true;
				this.adv_display.gameObject.SetActive(true);
			}
			this.once = true;
		}
	}

	public override IEnumerator load_texture()
	{
		return new advertise.$load_texture$727(this).GetEnumerator();
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Altitude_Display : MonoBehaviour
{
	public Transform quad_altitude;

	private string units_distance;

	private string units_standard;

	private float units_distance_m;

	public Altitude_Display()
	{
		this.units_distance = "Ft.";
		this.units_standard = "Imperial";
		this.units_distance_m = 3.2808f;
	}

	public override void Start()
	{
		if (Screen.height > 900)
		{
			this.guiText.fontSize = 25;
		}
		else if (Screen.height > 700 && Screen.height < 900)
		{
			this.guiText.fontSize = 20;
		}
		else
		{
			this.guiText.fontSize = 15;
		}
		this.units_standard = PlayerPrefs.GetString("Units");
		if (this.units_standard == "Imperial")
		{
			this.units_distance_m = 3.2808f;
			this.units_distance = "Ft.";
		}
		else
		{
			this.units_distance_m = (float)1;
			this.units_distance = "M";
		}
	}

	public override void LateUpdate()
	{
		this.guiText.fontSize = Screen.height / 35;
	}

	public override void Update()
	{
		this.guiText.text = (this.quad_altitude.position.y * this.units_distance_m).ToString("f0") + " " + this.units_distance;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Att_pitch : MonoBehaviour
{
	public Transform quad;

	public override void Start()
	{
	}

	public override void Update()
	{
		float x = -((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).pitch;
		Vector3 localEulerAngles = this.transform.localEulerAngles;
		float num = localEulerAngles.x = x;
		Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Att_roll : MonoBehaviour
{
	public Transform quad;

	public override void Start()
	{
	}

	public override void Update()
	{
		float y = -((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).roll;
		Vector3 eulerAngles = this.transform.eulerAngles;
		float num = eulerAngles.y = y;
		Vector3 vector = this.transform.eulerAngles = eulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Att_yaw : MonoBehaviour
{
	public Transform quad;

	public override void Start()
	{
	}

	public override void Update()
	{
		float yaw = ((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).yaw;
		Vector3 localEulerAngles = this.transform.localEulerAngles;
		float num = localEulerAngles.z = yaw;
		Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Boat_Control : MonoBehaviour
{
	public Transform Boat_1;

	public Transform Boat_2;

	public Transform Boat_3;

	public override void Start()
	{
	}

	public override void LateUpdate()
	{
		this.Boat_1.rigidbody.AddRelativeForce((float)0, (float)0, (float)15000 * Time.deltaTime);
		this.Boat_1.rigidbody.AddRelativeTorque((float)0, (float)-150, (float)0 * Time.deltaTime);
		this.Boat_2.rigidbody.AddRelativeForce((float)0, (float)0, (float)5000 * Time.deltaTime);
		this.Boat_2.rigidbody.AddRelativeTorque((float)0, (float)-50, (float)0 * Time.deltaTime);
		this.Boat_3.rigidbody.AddRelativeForce((float)0, (float)0, (float)5000 * Time.deltaTime);
		this.Boat_3.rigidbody.AddRelativeTorque((float)0, (float)-50, (float)0 * Time.deltaTime);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class cam_attitude : MonoBehaviour
{
	private string att_ind;

	private int display_size_w;

	private int display_size_h;

	public cam_attitude()
	{
		this.display_size_w = 300;
		this.display_size_h = 300;
	}

	public override void Start()
	{
		if (Screen.height > 900)
		{
			this.display_size_w = 500;
			this.display_size_h = 450;
		}
		else if (Screen.height > 700 && Screen.height < 900)
		{
			this.display_size_w = 400;
			this.display_size_h = 350;
		}
		else
		{
			this.display_size_w = 300;
			this.display_size_h = 280;
		}
		float x = 0.5f - (float)this.display_size_w / UnityBuiltins.parseFloat(Screen.width) * 0.5f;
		Rect rect = this.transform.camera.rect;
		float num = rect.x = x;
		Rect rect2 = this.transform.camera.rect = rect;
		float width = (float)this.display_size_w / UnityBuiltins.parseFloat(Screen.width);
		Rect rect3 = this.transform.camera.rect;
		float num2 = rect3.width = width;
		Rect rect4 = this.transform.camera.rect = rect3;
		float height = (float)this.display_size_h / UnityBuiltins.parseFloat(Screen.height);
		Rect rect5 = this.transform.camera.rect;
		float num3 = rect5.height = height;
		Rect rect6 = this.transform.camera.rect = rect5;
		if (!PlayerPrefs.HasKey("Attitude_Indicator"))
		{
			PlayerPrefs.SetString("Attitude_Indicator", "On");
		}
		this.att_ind = PlayerPrefs.GetString("Attitude_Indicator");
		if (this.att_ind == "Off")
		{
			this.camera.enabled = false;
		}
	}

	public override void LateUpdate()
	{
		this.display_size_w = (int)((float)Screen.height / 2f);
		this.display_size_h = (int)((float)Screen.height / 2f);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Boundary
{
	public Vector2 min;

	public Vector2 max;

	public Boundary()
	{
		this.min = Vector2.zero;
		this.max = Vector2.zero;
	}
}

using System;
using UnityEngine;

[Serializable]
public class Cam_Follow : MonoBehaviour
{
	public float follow_height;

	public float follow_distance;

	public override void Start()
	{
		float y = this.transform.position.y + this.follow_height;
		Vector3 position = this.transform.position;
		float num = position.y = y;
		Vector3 vector = this.transform.position = position;
		float z = this.transform.position.z - this.follow_distance;
		Vector3 position2 = this.transform.position;
		float num2 = position2.z = z;
		Vector3 vector2 = this.transform.position = position2;
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Cam_follow_Parent : MonoBehaviour
{
	public Transform follow_Object;

	private Transform thisTransform;

	private Vector2 angularvelocity;

	public float rotationDamping;

	public Cam_follow_Parent()
	{
		this.rotationDamping = 3f;
	}

	public override void Start()
	{
		this.thisTransform = this.transform;
	}

	public override void LateUpdate()
	{
		float num = this.transform.eulerAngles.y;
		float y = this.follow_Object.eulerAngles.y;
		float x = this.follow_Object.transform.position.x;
		Vector3 position = this.transform.position;
		float num2 = position.x = x;
		Vector3 vector = this.transform.position = position;
		float y2 = this.follow_Object.transform.position.y;
		Vector3 position2 = this.transform.position;
		float num3 = position2.y = y2;
		Vector3 vector2 = this.transform.position = position2;
		float z = this.follow_Object.transform.position.z;
		Vector3 position3 = this.transform.position;
		float num4 = position3.z = z;
		Vector3 vector3 = this.transform.position = position3;
		num = Mathf.LerpAngle(num, y, this.rotationDamping * Time.deltaTime);
		Quaternion quaternion = Quaternion.Euler((float)0, num, (float)0);
		float y3 = num;
		Vector3 eulerAngles = this.transform.eulerAngles;
		float num5 = eulerAngles.y = y3;
		Vector3 vector4 = this.transform.eulerAngles = eulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_Gimbal_Location : MonoBehaviour
{
	public override void Start()
	{
		if (PlayerPrefs.GetInt("Quad") == 0)
		{
			int num = 0;
			Vector3 localPosition = this.transform.localPosition;
			float num2 = localPosition.x = (float)num;
			Vector3 vector = this.transform.localPosition = localPosition;
			float y = 0.1341f;
			Vector3 localPosition2 = this.transform.localPosition;
			float num3 = localPosition2.y = y;
			Vector3 vector2 = this.transform.localPosition = localPosition2;
			float z = 0.1152f;
			Vector3 localPosition3 = this.transform.localPosition;
			float num4 = localPosition3.z = z;
			Vector3 vector3 = this.transform.localPosition = localPosition3;
		}
		if (PlayerPrefs.GetInt("Quad") == 1)
		{
			int num5 = 0;
			Vector3 localPosition4 = this.transform.localPosition;
			float num6 = localPosition4.x = (float)num5;
			Vector3 vector4 = this.transform.localPosition = localPosition4;
			float y2 = 0.1183f;
			Vector3 localPosition5 = this.transform.localPosition;
			float num7 = localPosition5.y = y2;
			Vector3 vector5 = this.transform.localPosition = localPosition5;
			float z2 = 0.051f;
			Vector3 localPosition6 = this.transform.localPosition;
			float num8 = localPosition6.z = z2;
			Vector3 vector6 = this.transform.localPosition = localPosition6;
			float r = 0.9f;
			Color color = this.transform.renderer.materials[0].color;
			float num9 = color.r = r;
			Color color2 = this.transform.renderer.materials[0].color = color;
			float g = 0.9f;
			Color color3 = this.transform.renderer.materials[0].color;
			float num10 = color3.g = g;
			Color color4 = this.transform.renderer.materials[0].color = color3;
			float b = 0.9f;
			Color color5 = this.transform.renderer.materials[0].color;
			float num11 = color5.b = b;
			Color color6 = this.transform.renderer.materials[0].color = color5;
			float r2 = 0.5f;
			Color color7 = this.transform.renderer.materials[1].color;
			float num12 = color7.r = r2;
			Color color8 = this.transform.renderer.materials[1].color = color7;
			float g2 = 0.5f;
			Color color9 = this.transform.renderer.materials[1].color;
			float num13 = color9.g = g2;
			Color color10 = this.transform.renderer.materials[1].color = color9;
			float b2 = 0.5f;
			Color color11 = this.transform.renderer.materials[1].color;
			float num14 = color11.b = b2;
			Color color12 = this.transform.renderer.materials[1].color = color11;
		}
		if (PlayerPrefs.GetInt("Quad") == 2)
		{
			int num15 = 0;
			Vector3 localPosition7 = this.transform.localPosition;
			float num16 = localPosition7.x = (float)num15;
			Vector3 vector7 = this.transform.localPosition = localPosition7;
			float y3 = 0.123f;
			Vector3 localPosition8 = this.transform.localPosition;
			float num17 = localPosition8.y = y3;
			Vector3 vector8 = this.transform.localPosition = localPosition8;
			float z3 = 0.052f;
			Vector3 localPosition9 = this.transform.localPosition;
			float num18 = localPosition9.z = z3;
			Vector3 vector9 = this.transform.localPosition = localPosition9;
		}
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_Gimbal clipping_Distance : MonoBehaviour
{
	public Transform quad_c;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (this.quad_c.position.y > (float)10 && this.quad_c.position.y < (float)50)
		{
			this.transform.camera.nearClipPlane = 0.3f;
		}
		else if (this.quad_c.position.y > (float)50 && this.quad_c.position.y < (float)100)
		{
			this.transform.camera.nearClipPlane = (float)1;
		}
		else if (this.quad_c.position.y > (float)100)
		{
			this.transform.camera.nearClipPlane = (float)10;
		}
		else
		{
			this.transform.camera.nearClipPlane = 0.04f;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_Gimbal_Location_S : MonoBehaviour
{
	public Transform quad_s;

	public override void Update()
	{
		if (((Quad_Select)this.quad_s.GetComponent(typeof(Quad_Select))).quad_selected == 0)
		{
			int num = 0;
			Vector3 localPosition = this.transform.localPosition;
			float num2 = localPosition.x = (float)num;
			Vector3 vector = this.transform.localPosition = localPosition;
			float y = 0.1341f;
			Vector3 localPosition2 = this.transform.localPosition;
			float num3 = localPosition2.y = y;
			Vector3 vector2 = this.transform.localPosition = localPosition2;
			float z = 0.1152f;
			Vector3 localPosition3 = this.transform.localPosition;
			float num4 = localPosition3.z = z;
			Vector3 vector3 = this.transform.localPosition = localPosition3;
			float r = 0.05f;
			Color color = this.transform.renderer.materials[0].color;
			float num5 = color.r = r;
			Color color2 = this.transform.renderer.materials[0].color = color;
			float g = 0.05f;
			Color color3 = this.transform.renderer.materials[0].color;
			float num6 = color3.g = g;
			Color color4 = this.transform.renderer.materials[0].color = color3;
			float b = 0.05f;
			Color color5 = this.transform.renderer.materials[0].color;
			float num7 = color5.b = b;
			Color color6 = this.transform.renderer.materials[0].color = color5;
			float r2 = 0.1f;
			Color color7 = this.transform.renderer.materials[1].color;
			float num8 = color7.r = r2;
			Color color8 = this.transform.renderer.materials[1].color = color7;
			float g2 = 0.1f;
			Color color9 = this.transform.renderer.materials[1].color;
			float num9 = color9.g = g2;
			Color color10 = this.transform.renderer.materials[1].color = color9;
			float b2 = 0.1f;
			Color color11 = this.transform.renderer.materials[1].color;
			float num10 = color11.b = b2;
			Color color12 = this.transform.renderer.materials[1].color = color11;
		}
		if (((Quad_Select)this.quad_s.GetComponent(typeof(Quad_Select))).quad_selected == 1)
		{
			int num11 = 0;
			Vector3 localPosition4 = this.transform.localPosition;
			float num12 = localPosition4.x = (float)num11;
			Vector3 vector4 = this.transform.localPosition = localPosition4;
			float y2 = 0.1183f;
			Vector3 localPosition5 = this.transform.localPosition;
			float num13 = localPosition5.y = y2;
			Vector3 vector5 = this.transform.localPosition = localPosition5;
			float z2 = 0.051f;
			Vector3 localPosition6 = this.transform.localPosition;
			float num14 = localPosition6.z = z2;
			Vector3 vector6 = this.transform.localPosition = localPosition6;
			float r3 = 0.9f;
			Color color13 = this.transform.renderer.materials[0].color;
			float num15 = color13.r = r3;
			Color color14 = this.transform.renderer.materials[0].color = color13;
			float g3 = 0.9f;
			Color color15 = this.transform.renderer.materials[0].color;
			float num16 = color15.g = g3;
			Color color16 = this.transform.renderer.materials[0].color = color15;
			float b3 = 0.9f;
			Color color17 = this.transform.renderer.materials[0].color;
			float num17 = color17.b = b3;
			Color color18 = this.transform.renderer.materials[0].color = color17;
			float r4 = 0.5f;
			Color color19 = this.transform.renderer.materials[1].color;
			float num18 = color19.r = r4;
			Color color20 = this.transform.renderer.materials[1].color = color19;
			float g4 = 0.5f;
			Color color21 = this.transform.renderer.materials[1].color;
			float num19 = color21.g = g4;
			Color color22 = this.transform.renderer.materials[1].color = color21;
			float b4 = 0.5f;
			Color color23 = this.transform.renderer.materials[1].color;
			float num20 = color23.b = b4;
			Color color24 = this.transform.renderer.materials[1].color = color23;
		}
		if (((Quad_Select)this.quad_s.GetComponent(typeof(Quad_Select))).quad_selected == 2)
		{
			int num21 = 0;
			Vector3 localPosition7 = this.transform.localPosition;
			float num22 = localPosition7.x = (float)num21;
			Vector3 vector7 = this.transform.localPosition = localPosition7;
			float y3 = 0.123f;
			Vector3 localPosition8 = this.transform.localPosition;
			float num23 = localPosition8.y = y3;
			Vector3 vector8 = this.transform.localPosition = localPosition8;
			float z3 = 0.052f;
			Vector3 localPosition9 = this.transform.localPosition;
			float num24 = localPosition9.z = z3;
			Vector3 vector9 = this.transform.localPosition = localPosition9;
			float r5 = 0.05f;
			Color color25 = this.transform.renderer.materials[0].color;
			float num25 = color25.r = r5;
			Color color26 = this.transform.renderer.materials[0].color = color25;
			float g5 = 0.05f;
			Color color27 = this.transform.renderer.materials[0].color;
			float num26 = color27.g = g5;
			Color color28 = this.transform.renderer.materials[0].color = color27;
			float b5 = 0.05f;
			Color color29 = this.transform.renderer.materials[0].color;
			float num27 = color29.b = b5;
			Color color30 = this.transform.renderer.materials[0].color = color29;
			float r6 = 0.1f;
			Color color31 = this.transform.renderer.materials[1].color;
			float num28 = color31.r = r6;
			Color color32 = this.transform.renderer.materials[1].color = color31;
			float g6 = 0.1f;
			Color color33 = this.transform.renderer.materials[1].color;
			float num29 = color33.g = g6;
			Color color34 = this.transform.renderer.materials[1].color = color33;
			float b6 = 0.1f;
			Color color35 = this.transform.renderer.materials[1].color;
			float num30 = color35.b = b6;
			Color color36 = this.transform.renderer.materials[1].color = color35;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_GUI_Change_button : MonoBehaviour
{
	private int screen_center_width;

	public GUISkin customSkin;

	public Transform[] cams;

	public Transform Camera_VR;

	private int count;

	public Transform joystick_cam;

	public int cam_sel;

	public bool VR_on;

	public Transform Attitude_Camera;

	public Transform Advertisement;

	public Transform VR_Text_Display;

	public Transform quad;

	public int camera_change;

	private string[] camera_selected;

	private int height_pos;

	private float VR_start_time;

	private bool VR_Purchased;

	public Camera_GUI_Change_button()
	{
		this.cams = new Transform[7];
		this.camera_selected = new string[]
		{
			"Eye Level",
			"First Person View 1",
			"Gimbal",
			"Follow",
			"First Person View 2"
		};
	}

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Enable_VR_purchased") != 1)
		{
			this.VR_start_time = Time.time;
			this.VR_Purchased = false;
		}
		else if (PlayerPrefs.GetInt("Enable_VR_purchased") == 1)
		{
			this.VR_Purchased = true;
		}
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.Camera_VR.gameObject.SetActive(true);
			((Cardboard)this.Camera_VR.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			this.Attitude_Camera.camera.enabled = false;
			this.Advertisement.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.Camera_VR.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.Camera_VR.gameObject.SetActive(false);
			this.Attitude_Camera.camera.enabled = true;
			this.Advertisement.gameObject.SetActive(true);
		}
		this.camera_change = PlayerPrefs.GetInt("Camera");
		this.screen_center_width = Screen.width / 2;
		int num = Screen.width / 2;
		Vector2 pixelOffset = this.guiText.pixelOffset;
		float num2 = pixelOffset.x = (float)num;
		Vector2 vector = this.guiText.pixelOffset = pixelOffset;
		int num3 = Screen.height - 20;
		Vector2 pixelOffset2 = this.guiText.pixelOffset;
		float num4 = pixelOffset2.y = (float)num3;
		Vector2 vector2 = this.guiText.pixelOffset = pixelOffset2;
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num5 = pixelInset.x = x;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num7 = pixelInset2.y = (float)num6;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		this.count = this.camera_change;
		this.guiText.text = this.camera_selected[this.camera_change];
		if (this.count >= 1)
		{
			this.count++;
		}
		this.change_camera();
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		this.height_pos = Screen.height / 6;
		int num3 = Screen.width / 2;
		Vector2 pixelOffset = this.guiText.pixelOffset;
		float num4 = pixelOffset.x = (float)num3;
		Vector2 vector = this.guiText.pixelOffset = pixelOffset;
		float y = (float)Screen.height - (float)Screen.height / 36f;
		Vector2 pixelOffset2 = this.guiText.pixelOffset;
		float num5 = pixelOffset2.y = y;
		Vector2 vector2 = this.guiText.pixelOffset = pixelOffset2;
		this.guiText.fontSize = Screen.width / 40;
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num6 = pixelInset3.x = x;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		int num7 = Screen.height - this.height_pos;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num8 = pixelInset4.y = (float)num7;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
		if (this.VR_on)
		{
			this.GUI_VR_Text();
			this.reset_VR();
		}
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.change_camera();
				}
			}
		}
		if (Input.GetButtonDown("Next"))
		{
			this.change_camera();
		}
	}

	public override void change_camera()
	{
		this.cam_sel = this.count;
		if (!this.VR_on)
		{
			this.VR_Text_Display.guiText.fontSize = Screen.height / 30;
			this.VR_Text_Display.guiText.text = string.Empty;
			if (this.count == 0)
			{
				this.cams[0].gameObject.SetActive(true);
				this.cams[1].gameObject.SetActive(true);
				this.cams[2].gameObject.SetActive(false);
				this.cams[3].gameObject.SetActive(false);
				this.cams[4].gameObject.SetActive(false);
				this.cams[5].gameObject.SetActive(false);
				this.cams[6].gameObject.SetActive(false);
				this.cams[7].gameObject.SetActive(false);
				this.joystick_cam.gameObject.SetActive(true);
				this.count = 2;
				this.guiText.text = "Camera Eye Level";
			}
			else if (this.count == 2)
			{
				this.cams[0].gameObject.SetActive(false);
				this.cams[1].gameObject.SetActive(false);
				this.cams[2].gameObject.SetActive(true);
				this.cams[3].gameObject.SetActive(false);
				this.cams[4].gameObject.SetActive(false);
				this.cams[5].gameObject.SetActive(false);
				this.cams[6].gameObject.SetActive(false);
				this.cams[7].gameObject.SetActive(false);
				this.joystick_cam.gameObject.SetActive(true);
				this.count = 3;
				this.guiText.text = "Camera FPV 1";
			}
			else if (this.count == 3)
			{
				this.cams[0].gameObject.SetActive(false);
				this.cams[1].gameObject.SetActive(false);
				this.cams[2].gameObject.SetActive(false);
				this.cams[3].gameObject.SetActive(true);
				this.cams[4].gameObject.SetActive(false);
				this.cams[5].gameObject.SetActive(false);
				this.cams[6].gameObject.SetActive(false);
				this.cams[7].gameObject.SetActive(true);
				this.joystick_cam.gameObject.SetActive(true);
				this.count = 4;
				this.guiText.text = "Camera Gimbal";
			}
			else if (this.count == 4)
			{
				this.cams[0].gameObject.SetActive(false);
				this.cams[1].gameObject.SetActive(false);
				this.cams[2].gameObject.SetActive(false);
				this.cams[3].gameObject.SetActive(false);
				this.cams[4].gameObject.SetActive(true);
				this.cams[5].gameObject.SetActive(true);
				this.cams[6].gameObject.SetActive(false);
				this.cams[7].gameObject.SetActive(false);
				this.joystick_cam.gameObject.SetActive(false);
				this.count = 5;
				this.guiText.text = "Camera Follow";
			}
			else if (this.count == 5)
			{
				this.cams[0].gameObject.SetActive(false);
				this.cams[1].gameObject.SetActive(false);
				this.cams[2].gameObject.SetActive(false);
				this.cams[3].gameObject.SetActive(false);
				this.cams[4].gameObject.SetActive(false);
				this.cams[5].gameObject.SetActive(false);
				this.cams[6].gameObject.SetActive(true);
				this.cams[7].gameObject.SetActive(false);
				this.joystick_cam.gameObject.SetActive(false);
				this.count = 0;
				this.guiText.text = "Camera FPV 2";
			}
		}
		else if (this.VR_on)
		{
			this.cams[0].gameObject.SetActive(false);
			this.cams[1].gameObject.SetActive(false);
			this.cams[2].gameObject.SetActive(false);
			this.cams[3].gameObject.SetActive(false);
			this.cams[4].gameObject.SetActive(false);
			this.cams[5].gameObject.SetActive(false);
			this.cams[6].gameObject.SetActive(false);
			this.cams[7].gameObject.SetActive(false);
			this.joystick_cam.gameObject.SetActive(false);
			int num = this.cam_sel;
			if (num == 0)
			{
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).target = this.cams[0];
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).trackRotation = true;
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).enableHeadTracking = true;
				this.count = 2;
			}
			else if (num == 2)
			{
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).target = this.cams[2];
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).trackRotation = true;
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).enableHeadTracking = false;
				this.count = 3;
			}
			else if (num == 3)
			{
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).target = this.cams[3];
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).trackRotation = true;
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).enableHeadTracking = false;
				this.count = 6;
			}
			else if (num == 6)
			{
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).target = this.cams[6];
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).trackRotation = true;
				((CardboardHead)this.Camera_VR.GetComponent(typeof(CardboardHead))).enableHeadTracking = false;
				this.count = 0;
			}
		}
	}

	public override void GUI_VR_Text()
	{
		this.VR_Text_Display.guiText.fontSize = Screen.height / 30;
		if (((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			this.VR_Text_Display.guiText.text = "Smart Mode";
			if (((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 3)
			{
				this.VR_Text_Display.guiText.text = "Home Lock";
			}
			if (((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 2)
			{
				this.VR_Text_Display.guiText.text = "Course Lock";
			}
		}
		else if (!((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			if (((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold)
			{
				this.VR_Text_Display.guiText.text = "Altitude Hold";
			}
			else
			{
				int flying_mode = ((Quad_Dynamics_independent_propeller)this.quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).flying_mode;
				if (flying_mode == 0)
				{
					this.VR_Text_Display.guiText.text = string.Empty;
				}
				else if (flying_mode == 1)
				{
					this.VR_Text_Display.guiText.text = string.Empty;
				}
				else if (flying_mode == 2)
				{
					this.VR_Text_Display.guiText.text = "Acro Mode";
				}
				else if (flying_mode == 3)
				{
					this.VR_Text_Display.guiText.text = "3D Acro Mode";
				}
			}
		}
	}

	public override void reset_VR()
	{
		if (!this.VR_Purchased)
		{
			if (Time.time > this.VR_start_time + (float)60)
			{
				this.VR_Text_Display.guiText.text = "Resetting Trial VR mode in: " + (this.VR_start_time + (float)90 - Time.time).ToString("f0") + " secs.";
			}
			if (Time.time > this.VR_start_time + (float)90)
			{
				Application.LoadLevel(0);
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_Near_Distance : MonoBehaviour
{
	public Transform quad_c;

	private int scene_selected;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
	}

	public override void Update()
	{
		if (this.scene_selected == 1)
		{
			if (this.quad_c.position.y > (float)10 && this.quad_c.position.y < (float)50)
			{
				this.transform.camera.nearClipPlane = 0.3f;
			}
			else if (this.quad_c.position.y > (float)50 && this.quad_c.position.y < (float)100)
			{
				this.transform.camera.nearClipPlane = (float)1;
			}
			else if (this.quad_c.position.y > (float)100)
			{
				this.transform.camera.nearClipPlane = (float)10;
			}
			else
			{
				this.transform.camera.nearClipPlane = 0.04f;
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_rotate : MonoBehaviour
{
	public Transform joystick_Center;

	private float up_down;

	private float right_left;

	private float up_down_a;

	private float right_left_a;

	private bool reset_cam;

	private bool VR_on;

	private bool VR_on_HT;

	public Transform VR_track_FPV;

	public int tilt_angle;

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		this.tilt_angle = PlayerPrefs.GetInt("Camera_FPV_Tilt");
	}

	public override void FixedUpdate()
	{
		if (this.VR_on && this.VR_on_HT)
		{
			this.up_down = -Input.gyro.attitude.eulerAngles.x;
			this.right_left = -Input.gyro.attitude.eulerAngles.y;
			int num = 85;
			Vector3 localEulerAngles = this.VR_track_FPV.localEulerAngles;
			float num2 = localEulerAngles.x = (float)num;
			Vector3 vector = this.VR_track_FPV.localEulerAngles = localEulerAngles;
			this.right_left_a = Mathf.Clamp(this.right_left, (float)-60, (float)60);
			this.up_down_a = Mathf.Clamp(this.up_down, (float)-85, (float)85);
		}
		else
		{
			this.up_down = -((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).position.y;
			this.right_left = ((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).position.x;
			this.right_left_a = Mathf.Clamp(this.right_left + this.right_left_a, (float)-60, (float)60);
			this.up_down_a = Mathf.Clamp(this.up_down + this.up_down_a, (float)(-85 + this.tilt_angle), (float)(85 + this.tilt_angle));
			this.reset_cam = ((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).reset_cam;
		}
		float x = this.up_down_a - (float)this.tilt_angle;
		Vector3 localEulerAngles2 = this.transform.localEulerAngles;
		float num3 = localEulerAngles2.x = x;
		Vector3 vector2 = this.transform.localEulerAngles = localEulerAngles2;
		float y = this.right_left_a;
		Vector3 localEulerAngles3 = this.transform.localEulerAngles;
		float num4 = localEulerAngles3.y = y;
		Vector3 vector3 = this.transform.localEulerAngles = localEulerAngles3;
		if (this.reset_cam)
		{
			this.up_down_a = (float)PlayerPrefs.GetInt("Camera_FPV_Tilt");
			this.right_left_a = (float)0;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_rotate_Gimbal : MonoBehaviour
{
	public Transform joystick_Center;

	private float up_down;

	private float up_down_a;

	private bool reset_cam;

	public override void Start()
	{
	}

	public override void FixedUpdate()
	{
		this.up_down = -((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).position.y;
		this.up_down_a = Mathf.Clamp(this.up_down + this.up_down_a, (float)-85, (float)85);
		float x = this.up_down_a;
		Vector3 localEulerAngles = this.transform.localEulerAngles;
		float num = localEulerAngles.x = x;
		Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
		this.reset_cam = ((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).reset_cam;
		if (this.reset_cam)
		{
			this.up_down_a = (float)0;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Camera_tilt : MonoBehaviour
{
	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[Serializable]
public class CameraRelativeControl : MonoBehaviour
{
	public Joystick moveJoystick;

	public Joystick rotateJoystick;

	public Transform cameraPivot;

	public Transform cameraTransform;

	public float speed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 velocity;

	private bool canJump;

	public CameraRelativeControl()
	{
		this.speed = (float)5;
		this.jumpSpeed = (float)8;
		this.inAirMultiplier = 0.25f;
		this.rotationSpeed = new Vector2((float)50, (float)25);
		this.canJump = true;
	}

	public override void Start()
	{
		this.thisTransform = (Transform)this.GetComponent(typeof(Transform));
		this.character = (CharacterController)this.GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if (gameObject)
		{
			this.thisTransform.position = gameObject.transform.position;
		}
	}

	public override void FaceMovementDirection()
	{
		Vector3 vector = this.character.velocity;
		vector.y = (float)0;
		if (vector.magnitude > 0.1f)
		{
			this.thisTransform.forward = vector.normalized;
		}
	}

	public override void OnEndGame()
	{
		this.moveJoystick.Disable();
		this.rotateJoystick.Disable();
		this.enabled = false;
	}

	public override void Update()
	{
		Vector3 vector = this.cameraTransform.TransformDirection(new Vector3(this.moveJoystick.position.x, (float)0, this.moveJoystick.position.y));
		vector.y = (float)0;
		vector.Normalize();
		Vector2 vector2 = new Vector2(Mathf.Abs(this.moveJoystick.position.x), Mathf.Abs(this.moveJoystick.position.y));
		vector *= this.speed * ((vector2.x <= vector2.y) ? vector2.y : vector2.x);
		if (this.character.isGrounded)
		{
			if (!this.rotateJoystick.IsFingerDown())
			{
				this.canJump = true;
			}
			if (this.canJump && this.rotateJoystick.tapCount == 2)
			{
				this.velocity = this.character.velocity;
				this.velocity.y = this.jumpSpeed;
				this.canJump = false;
			}
		}
		else
		{
			this.velocity.y = this.velocity.y + Physics.gravity.y * Time.deltaTime;
			vector.x *= this.inAirMultiplier;
			vector.z *= this.inAirMultiplier;
		}
		vector += this.velocity;
		vector += Physics.gravity;
		vector *= Time.deltaTime;
		this.character.Move(vector);
		if (this.character.isGrounded)
		{
			this.velocity = Vector3.zero;
		}
		this.FaceMovementDirection();
		Vector2 a = this.rotateJoystick.position;
		a.x *= this.rotationSpeed.x;
		a.y *= this.rotationSpeed.y;
		a *= Time.deltaTime;
		this.cameraPivot.Rotate((float)0, a.x, (float)0, Space.World);
		this.cameraPivot.Rotate(a.y, (float)0, (float)0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Challenge1 : MonoBehaviour
{
	public Transform landing_pad;

	public Transform rectangle;

	public Transform displaytext;

	public Transform displaytime;

	public Transform quads;

	private float start_time;

	private float current_time;

	private float end_time;

	private bool check_once_s;

	private bool check_once_p;

	private bool check_once_e;

	private int challenge_sel;

	private float chall_Best_Time;

	private string new_record;

	private bool check_time_end;

	private int random_place;

	private bool ch_failed;

	private int loop_complete;

	private bool half_loop_cc;

	private int cc;

	private bool half_loop_cl;

	private int cl;

	public Challenge1()
	{
		this.new_record = string.Empty;
	}

	public override void Start()
	{
		this.new_record = string.Empty;
		this.rectangle.renderer.enabled = false;
		this.landing_pad.renderer.enabled = false;
		this.challenge_sel = PlayerPrefs.GetInt("Challenge_selected");
		if (this.challenge_sel == 1)
		{
			this.chall_Best_Time = PlayerPrefs.GetFloat("Challenge_1_Best_time");
			this.rectangle.transform.position = new Vector3((float)-13, 5.66f, (float)-5);
			this.rectangle.transform.eulerAngles = new Vector3((float)270, (float)90, (float)0);
			this.landing_pad.transform.position = new Vector3((float)-25, 0.15f, (float)-5);
			this.rectangle.renderer.enabled = true;
			this.landing_pad.renderer.enabled = true;
			this.displaytime.guiText.text = "0.00 Secs";
			this.displaytext.guiText.text = "Climb and Fly North through yellow\nrectangle at around 18 ft.";
		}
		if (this.challenge_sel == 2)
		{
			this.chall_Best_Time = PlayerPrefs.GetFloat("Challenge_2_Best_time");
			this.landing_pad.transform.position = new Vector3(-23.73f, 8.147f, (float)5);
			this.landing_pad.renderer.enabled = true;
			this.displaytime.guiText.text = "0.00 Secs";
			this.displaytext.guiText.text = "Climb and Fly North and Land on Yellow\nQuadpad in the Tower's opening";
		}
		if (this.challenge_sel == 3)
		{
			this.chall_Best_Time = PlayerPrefs.GetFloat("Challenge_3_Best_time");
			this.random_place = UnityEngine.Random.Range(1, 10);
			if (this.random_place == 1)
			{
				this.landing_pad.transform.position = new Vector3(-14.55f, 9.25f, -25.2f);
			}
			if (this.random_place == 2)
			{
				this.landing_pad.transform.position = new Vector3(-38.5f, 3.17f, -35.02f);
			}
			if (this.random_place == 3)
			{
				this.landing_pad.transform.position = new Vector3(32.5f, 19.53f, -37.5f);
			}
			if (this.random_place == 4)
			{
				this.landing_pad.transform.position = new Vector3(60.5f, 0.15f, (float)-18);
			}
			if (this.random_place == 5)
			{
				this.landing_pad.transform.position = new Vector3(-24.5f, 0.15f, 30.5f);
			}
			if (this.random_place == 6)
			{
				this.landing_pad.transform.position = new Vector3(-23.7f, 24.05f, 8.5f);
			}
			if (this.random_place == 7)
			{
				this.landing_pad.transform.position = new Vector3(-6.4f, 0.31f, (float)-35);
			}
			if (this.random_place == 8)
			{
				this.landing_pad.transform.position = new Vector3((float)0, 24.5f, (float)-33);
			}
			if (this.random_place == 9)
			{
				this.landing_pad.transform.position = new Vector3((float)23, 0.15f, -19.5f);
			}
			if (this.random_place == 10)
			{
				this.landing_pad.transform.position = new Vector3(-0.05f, 0.15f, -32.4f);
			}
			this.landing_pad.renderer.enabled = true;
			this.displaytime.guiText.text = "0.00 Secs";
			this.displaytext.guiText.text = "Find the Quadpad in this\nFactory Complex and Land";
		}
		if (this.challenge_sel == 4)
		{
			this.chall_Best_Time = PlayerPrefs.GetFloat("Challenge_4_Best_time");
			this.rectangle.transform.position = new Vector3(-6.3f, 13.9f, -29.5f);
			this.landing_pad.transform.position = new Vector3(-6.3f, 15.78f, -29.5f);
			this.rectangle.renderer.enabled = true;
			this.landing_pad.renderer.enabled = true;
			this.displaytime.guiText.text = "0.00 Secs";
			this.displaytext.guiText.text = "Find and Fly through Yellow Rectangle";
		}
		if (this.challenge_sel == 5)
		{
			this.chall_Best_Time = PlayerPrefs.GetFloat("Challenge_5_Best_time");
			this.random_place = UnityEngine.Random.Range(1, 10);
			if (this.random_place == 1)
			{
				this.landing_pad.transform.position = new Vector3(-14.55f, 9.25f, -25.2f);
			}
			if (this.random_place == 2)
			{
				this.landing_pad.transform.position = new Vector3(-38.5f, 3.17f, -35.02f);
			}
			if (this.random_place == 3)
			{
				this.landing_pad.transform.position = new Vector3(32.5f, 19.53f, -37.5f);
			}
			if (this.random_place == 4)
			{
				this.landing_pad.transform.position = new Vector3(60.5f, 0.15f, (float)-18);
			}
			if (this.random_place == 5)
			{
				this.landing_pad.transform.position = new Vector3(-24.5f, 0.15f, 30.5f);
			}
			if (this.random_place == 6)
			{
				this.landing_pad.transform.position = new Vector3(-23.7f, 24.05f, 8.5f);
			}
			if (this.random_place == 7)
			{
				this.landing_pad.transform.position = new Vector3(-6.4f, 0.31f, (float)-35);
			}
			if (this.random_place == 8)
			{
				this.landing_pad.transform.position = new Vector3((float)0, 24.5f, (float)-33);
			}
			if (this.random_place == 9)
			{
				this.landing_pad.transform.position = new Vector3((float)23, 0.15f, -19.5f);
			}
			if (this.random_place == 10)
			{
				this.landing_pad.transform.position = new Vector3(-0.05f, 0.15f, -32.4f);
			}
			this.landing_pad.renderer.enabled = true;
			this.displaytime.guiText.text = "0.00 Secs";
			this.displaytext.guiText.text = "Do 5 sideways loops staying below 100 ft. ";
		}
	}

	public override void LateUpdate()
	{
		this.displaytext.guiText.fontSize = Screen.height / 30;
		this.displaytime.guiText.fontSize = Screen.height / 30;
	}

	public override void FixedUpdate()
	{
		if (this.challenge_sel == 1)
		{
			this.challenge_1();
		}
		if (this.challenge_sel == 2)
		{
			this.challenge_2();
		}
		if (this.challenge_sel == 3)
		{
			this.challenge_3();
		}
		if (this.challenge_sel == 4)
		{
			this.challenge_4();
		}
		if (this.challenge_sel == 5)
		{
			this.challenge_5();
		}
	}

	public override void challenge_1()
	{
		if (!this.check_once_s && ((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).joy_in_throttle > 0.02f && !((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).on_ground)
		{
			this.start_time = Time.time;
			this.check_once_s = true;
		}
		if (this.check_once_s)
		{
			this.current_time = Time.time - this.start_time;
		}
		if (!this.check_time_end)
		{
			this.displaytime.guiText.text = this.current_time.ToString("f2") + " secs";
		}
		if (((Pass_through_Rect)this.rectangle.GetComponent(typeof(Pass_through_Rect))).Pass_th_Coll && !this.check_once_p)
		{
			this.displaytext.guiText.text = "Land at yellow Quadpad ahead";
			this.check_once_p = true;
		}
		if (((Pass_through_Rect)this.rectangle.GetComponent(typeof(Pass_through_Rect))).Pass_th_Coll && ((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && !this.check_once_e)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_1_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
	}

	public override void challenge_2()
	{
		if (!this.check_once_s && ((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).in_throttle > 0.05f)
		{
			this.start_time = Time.time;
			this.check_once_s = true;
		}
		if (this.check_once_s)
		{
			this.current_time = Time.time - this.start_time;
		}
		if (!this.check_time_end)
		{
			this.displaytime.guiText.text = this.current_time.ToString("f2") + " secs";
		}
		if (((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && !this.check_once_e)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_2_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
	}

	public override void challenge_3()
	{
		if (!this.check_once_s && ((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).in_throttle > 0.05f)
		{
			this.start_time = Time.time;
			this.check_once_s = true;
		}
		if (this.check_once_s)
		{
			this.current_time = Time.time - this.start_time;
		}
		if (!this.check_time_end)
		{
			this.displaytime.guiText.text = this.current_time.ToString("f2") + " secs";
		}
		if (((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && !this.check_once_e)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_3_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
	}

	public override void challenge_4()
	{
		if (!this.check_once_s && ((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).in_throttle > 0.05f)
		{
			this.start_time = Time.time;
			this.check_once_s = true;
		}
		if (this.check_once_s)
		{
			this.current_time = Time.time - this.start_time;
		}
		if (!this.check_time_end)
		{
			this.displaytime.guiText.text = this.current_time.ToString("f2") + " secs";
		}
		if (((Pass_through_Rect)this.rectangle.GetComponent(typeof(Pass_through_Rect))).Pass_th_Coll && !this.check_once_p)
		{
			this.displaytext.guiText.text = "Find and Land at Quadpad";
			this.check_once_p = true;
		}
		if (((Pass_through_Rect)this.rectangle.GetComponent(typeof(Pass_through_Rect))).Pass_th_Coll && ((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && !this.check_once_e)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_4_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
		if (((Pass_through_Rect)this.rectangle.GetComponent(typeof(Pass_through_Rect))).Pass_th_Coll && ((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && !this.check_once_e)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_4_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
	}

	public override void challenge_5()
	{
		if (!this.check_once_s && ((Quad_Dynamics_independent_propeller)this.quads.GetComponent(typeof(Quad_Dynamics_independent_propeller))).in_throttle > 0.05f)
		{
			this.start_time = Time.time;
			this.check_once_s = true;
		}
		if (this.check_once_s)
		{
			this.current_time = Time.time - this.start_time;
		}
		if (!this.ch_failed)
		{
			if (this.loop_complete < 5)
			{
				this.detectLoop();
			}
			if (this.loop_complete < 5 && this.quads.position.y > (float)31)
			{
				this.displaytext.guiText.text = "Crossed Height 100 ft .. Challenge Failed";
				this.ch_failed = true;
				this.check_time_end = true;
			}
		}
		if (!this.check_time_end)
		{
			this.displaytime.guiText.text = this.current_time.ToString("f2") + " secs";
		}
		if (this.loop_complete >= 5 && !this.check_once_p && !this.ch_failed)
		{
			this.displaytext.guiText.text = "Find Quadpad and Land";
			this.check_once_p = true;
		}
		if (((Landing_Rect)this.landing_pad.GetComponent(typeof(Landing_Rect))).coll_stay_check && this.loop_complete >= 5 && !this.check_once_e && !this.ch_failed)
		{
			this.check_time_end = true;
			if (this.chall_Best_Time < (float)1)
			{
				this.chall_Best_Time = (float)1500;
			}
			if (this.current_time < this.chall_Best_Time)
			{
				this.new_record = "New Record Time!! ";
				PlayerPrefs.SetFloat("Challenge_5_Best_time", this.current_time);
			}
			this.displaytext.guiText.text = "Congrats.. Challenge Completed";
			this.end_time = this.current_time;
			this.displaytime.guiText.text = this.new_record + this.end_time.ToString("f2") + " secs";
			this.check_once_e = true;
		}
	}

	public override void detectLoop()
	{
		float num = (float)0;
		if (this.quads.eulerAngles.z > (float)90 && this.quads.eulerAngles.z < (float)160)
		{
			this.cc = 1;
			num = Time.time;
		}
		if (this.quads.eulerAngles.z > (float)160 && this.quads.eulerAngles.z < (float)220 && this.cc == 1)
		{
			this.cc = 2;
		}
		if (this.quads.eulerAngles.z > (float)220 && this.quads.eulerAngles.z < (float)280 && this.cc == 2)
		{
			this.cc = 3;
		}
		if (this.quads.eulerAngles.z > (float)280 && this.quads.eulerAngles.z < (float)360 && this.cc == 3)
		{
			this.cc = 4;
		}
		if (this.quads.eulerAngles.z < (float)270 && this.quads.eulerAngles.z > (float)220)
		{
			this.cl = 1;
			num = Time.time;
		}
		if (this.quads.eulerAngles.z < (float)220 && this.quads.eulerAngles.z > (float)160 && this.cl == 1)
		{
			this.cl = 2;
		}
		if (this.quads.eulerAngles.z < (float)160 && this.quads.eulerAngles.z < (float)90 && this.cl == 2)
		{
			this.cl = 3;
		}
		if (this.quads.eulerAngles.z < (float)90 && this.quads.eulerAngles.z > (float)40 && this.cl == 3)
		{
			this.cl = 4;
		}
		if ((Time.time > num + (float)1 && this.quads.eulerAngles.z < (float)70) || this.quads.eulerAngles.z > (float)290)
		{
			this.cc = 0;
		}
		if (this.cc == 4 || this.cl == 4)
		{
			this.loop_complete++;
			this.displaytext.guiText.text = "Loop " + this.loop_complete + " Complete";
			this.cc = 0;
			this.cl = 0;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Challenges_button : MonoBehaviour
{
	private string challenge_button;

	private int height_pos;

	public Challenges_button()
	{
		this.challenge_button = "On";
	}

	public override void Start()
	{
		this.challenge_button = PlayerPrefs.GetString("Challenge_Button");
		if (this.challenge_button == "Off")
		{
			this.gameObject.SetActive(false);
		}
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		this.height_pos = (int)(this.guiTexture.pixelInset.height * -0.625f);
		int num3 = 20;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num4 = pixelInset3.x = (float)num3;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		float y = (float)Screen.height * 0.5f - (float)this.height_pos;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num5 = pixelInset4.y = y;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					Application.LoadLevel(5);
				}
			}
		}
		if (Input.GetButtonDown("Challenges"))
		{
			Application.LoadLevel(5);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Challenges_Select : MonoBehaviour
{
	public GUISkin customSkin_lowres;

	public GUISkin customSkin_medres;

	public GUISkin customSkin_highres;

	public Transform text_heading;

	public Transform text_challenge;

	public Transform text_time;

	public Transform Main_Camera;

	private GUISkin customSkin;

	public int challenge_selected;

	private int sl_w;

	private int sl_h;

	private string[] Challenges_Names;

	private string[] Challenges_Discription;

	private float[] Challenges_Best_time;

	private bool VR_on;

	public Transform VR_camera;

	public Transform canvas_events;

	public Transform Canvas_T;

	public Challenges_Select()
	{
		this.Challenges_Names = new string[6];
		this.Challenges_Discription = new string[6];
		this.Challenges_Best_time = new float[6];
	}

	public override void Start()
	{
		this.load_values();
		this.Challenges_Names[0] = "Free Flight (Default)";
		this.Challenges_Names[1] = "Practice1";
		this.Challenges_Names[2] = "Practice2";
		this.Challenges_Names[3] = "Find Quadpad";
		this.Challenges_Names[4] = "Find Rect and Quadpad";
		this.Challenges_Names[5] = "Sideways Loops";
		this.Challenges_Discription[0] = "Roam Around Freely Land Anywhere.";
		this.Challenges_Discription[1] = "Take off, Climb to around 18 feets, Passthrough the Yellow Rectangle at North and Land on the Yellow Quadpad further ahead North. FPV cameras Recommended";
		this.Challenges_Discription[2] = "Climb, Fly North and Land on Yellow Quadpad in the Tower's west opening. FPV cameras Recommended";
		this.Challenges_Discription[3] = "Find the Quadpad in this Factory Complex and Land. Location of quadpad is randomly selected out of 10 pre defined positions during Start of Challenge. Use FPV cameras";
		this.Challenges_Discription[4] = "Find and Fly through Yellow Rectangle and then Find the Landing Pad and Land on it.  Use FPV cameras";
		this.Challenges_Discription[5] = "Do 5 sideways loops staying below 100 ft. and then find the randomly located Quadpad and Land on it. Turn on Acro mode in Settings and increase Roll/Pitch senstivity for this challenge. Use FPV cameras for finding Landing Pad";
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.Main_Camera.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.Main_Camera.gameObject.SetActive(true);
		}
	}

	public override void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
		((Text)this.text_heading.gameObject.GetComponent(typeof(Text))).text = this.Challenges_Names[this.challenge_selected];
		((Text)this.text_time.gameObject.GetComponent(typeof(Text))).text = "Best Time: " + this.Challenges_Best_time[this.challenge_selected].ToString("f2");
		if (this.challenge_selected == 0)
		{
			((Text)this.text_time.gameObject.GetComponent(typeof(Text))).text = string.Empty;
		}
		else
		{
			((Text)this.text_time.gameObject.GetComponent(typeof(Text))).text = "Best Time: " + this.Challenges_Best_time[this.challenge_selected].ToString("f2");
		}
		((Text)this.text_challenge.gameObject.GetComponent(typeof(Text))).text = this.Challenges_Discription[this.challenge_selected];
	}

	public override void load_values()
	{
		this.challenge_selected = PlayerPrefs.GetInt("Challenge_selected");
		this.Challenges_Best_time[1] = PlayerPrefs.GetFloat("Challenge_1_Best_time");
		this.Challenges_Best_time[2] = PlayerPrefs.GetFloat("Challenge_2_Best_time");
		this.Challenges_Best_time[3] = PlayerPrefs.GetFloat("Challenge_3_Best_time");
		this.Challenges_Best_time[4] = PlayerPrefs.GetFloat("Challenge_4_Best_time");
		this.Challenges_Best_time[5] = PlayerPrefs.GetFloat("Challenge_5_Best_time");
	}

	public override void save_values()
	{
		PlayerPrefs.SetInt("Challenge_selected", this.challenge_selected);
	}

	public override void next_button()
	{
		if (this.challenge_selected == 5)
		{
			this.challenge_selected = 0;
		}
		else
		{
			this.challenge_selected++;
		}
	}

	public override void previous_button()
	{
		if (this.challenge_selected == 0)
		{
			this.challenge_selected = 5;
		}
		else
		{
			this.challenge_selected--;
		}
	}

	public override void select_button()
	{
		this.save_values();
		Application.LoadLevel(0);
	}

	public override void cancel_button()
	{
		Application.LoadLevel(0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Close : MonoBehaviour
{
	public Transform Text_pro;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.Text_pro.gameObject.SetActive(false);
				}
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class collision : MonoBehaviour
{
	public Transform target;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (this.target.rigidbody.velocity.magnitude > (float)4 && this.target.rigidbody.velocity.magnitude < (float)10)
		{
			float y = 0.3f;
			Vector3 localScale = this.transform.localScale;
			float num = localScale.y = y;
			Vector3 vector = this.transform.localScale = localScale;
		}
		else if (this.target.rigidbody.velocity.magnitude > (float)10)
		{
			float y2 = 0.7f;
			Vector3 localScale2 = this.transform.localScale;
			float num2 = localScale2.y = y2;
			Vector3 vector2 = this.transform.localScale = localScale2;
		}
		else if (this.target.rigidbody.velocity.magnitude > (float)1 && this.target.rigidbody.velocity.magnitude < (float)4)
		{
			float y3 = 0.1f;
			Vector3 localScale3 = this.transform.localScale;
			float num3 = localScale3.y = y3;
			Vector3 vector3 = this.transform.localScale = localScale3;
		}
		else
		{
			float y4 = 0.05f;
			Vector3 localScale4 = this.transform.localScale;
			float num4 = localScale4.y = y4;
			Vector3 vector4 = this.transform.localScale = localScale4;
		}
	}

	public override void Main()
	{
	}
}

using System;

[Serializable]
public enum ConstraintAxis
{
	X,
	Y,
	Z
}

using System;

[Serializable]
public enum ControlState
{
	WaitingForFirstTouch,
	WaitingForSecondTouch,
	MovingCharacter,
	WaitingForMovement,
	ZoomingCamera,
	RotatingCamera,
	WaitingForNoFingers
}

using System;
using UnityEngine;

[Serializable]
public class CourseLock_button : MonoBehaviour
{
	public Transform Quadcopter;

	public Transform butt_off;

	private string adv_set_enabled;

	public Transform adv_set_text;

	private bool VR_on;

	private int height_pos;

	public override void Start()
	{
		this.adv_set_enabled = PlayerPrefs.GetString("Inventory");
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f + this.guiTexture.pixelInset.height * 1.25f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 2)
		{
			float a = 0.5f;
			Color color = this.guiTexture.color;
			float num = color.a = a;
			Color color2 = this.guiTexture.color = color;
			int num2 = 0;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = (float)num2;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		else
		{
			int num4 = 0;
			Color color5 = this.guiTexture.color;
			float num5 = color5.a = (float)num4;
			Color color6 = this.guiTexture.color = color5;
			float a2 = 0.5f;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = a2;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (this.adv_set_enabled != "Subscribed" && this.adv_set_enabled != "Purchase Success")
		{
			float a3 = 0.2f;
			Color color9 = this.butt_off.guiTexture.color;
			float num7 = color9.a = a3;
			Color color10 = this.butt_off.guiTexture.color = color9;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_smart();
				}
			}
		}
		if (Input.GetButtonDown("CourseLock"))
		{
			this.execute_smart();
		}
	}

	public override void execute_smart()
	{
		if (this.adv_set_enabled == "Subscribed" || this.adv_set_enabled == "Purchase Success")
		{
			if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 2)
			{
				((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 1;
			}
			else
			{
				((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 2;
			}
		}
		else if (!this.VR_on)
		{
			this.adv_set_text.gameObject.SetActive(true);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Exit : MonoBehaviour
{
	private int scene_selected;

	private int Trial_Time_1;

	private int Trial_Time_2;

	private float scene_time;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.scene_time = Time.time;
	}

	public override void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (this.scene_selected == 1 && this.Trial_Time_1 < 120)
			{
				PlayerPrefs.SetInt("Scene_Try_Time_S1", (int)((float)this.Trial_Time_1 + Time.time - this.scene_time));
			}
			if (this.scene_selected == 2 && this.Trial_Time_2 < 120)
			{
				PlayerPrefs.SetInt("Scene_Try_Time_S2", (int)((float)this.Trial_Time_2 + Time.time - this.scene_time));
			}
			Application.LoadLevel(6);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[Serializable]
public class FirstPersonControl : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick rotateTouchPad;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	public float tiltPositiveYAxis;

	public float tiltNegativeYAxis;

	public float tiltXAxisMinimum;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	private bool canJump;

	public FirstPersonControl()
	{
		this.forwardSpeed = (float)4;
		this.backwardSpeed = (float)1;
		this.sidestepSpeed = (float)1;
		this.jumpSpeed = (float)8;
		this.inAirMultiplier = 0.25f;
		this.rotationSpeed = new Vector2((float)50, (float)25);
		this.tiltPositiveYAxis = 0.6f;
		this.tiltNegativeYAxis = 0.4f;
		this.tiltXAxisMinimum = 0.1f;
		this.canJump = true;
	}

	public override void Start()
	{
		this.thisTransform = (Transform)this.GetComponent(typeof(Transform));
		this.character = (CharacterController)this.GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if (gameObject)
		{
			this.thisTransform.position = gameObject.transform.position;
		}
	}

	public override void OnEndGame()
	{
		this.moveTouchPad.Disable();
		if (this.rotateTouchPad)
		{
			this.rotateTouchPad.Disable();
		}
		this.enabled = false;
	}

	public override void Update()
	{
		Vector3 vector = this.thisTransform.TransformDirection(new Vector3(this.moveTouchPad.position.x, (float)0, this.moveTouchPad.position.y));
		vector.y = (float)0;
		vector.Normalize();
		Vector2 vector2 = new Vector2(Mathf.Abs(this.moveTouchPad.position.x), Mathf.Abs(this.moveTouchPad.position.y));
		if (vector2.y > vector2.x)
		{
			if (this.moveTouchPad.position.y > (float)0)
			{
				vector *= this.forwardSpeed * vector2.y;
			}
			else
			{
				vector *= this.backwardSpeed * vector2.y;
			}
		}
		else
		{
			vector *= this.sidestepSpeed * vector2.x;
		}
		if (this.character.isGrounded)
		{
			bool flag = false;
			Joystick joystick;
			if (this.rotateTouchPad)
			{
				joystick = this.rotateTouchPad;
			}
			else
			{
				joystick = this.moveTouchPad;
			}
			if (!joystick.IsFingerDown())
			{
				this.canJump = true;
			}
			if (this.canJump && joystick.tapCount >= 2)
			{
				flag = true;
				this.canJump = false;
			}
			if (flag)
			{
				this.velocity = this.character.velocity;
				this.velocity.y = this.jumpSpeed;
			}
		}
		else
		{
			this.velocity.y = this.velocity.y + Physics.gravity.y * Time.deltaTime;
			vector.x *= this.inAirMultiplier;
			vector.z *= this.inAirMultiplier;
		}
		vector += this.velocity;
		vector += Physics.gravity;
		vector *= Time.deltaTime;
		this.character.Move(vector);
		if (this.character.isGrounded)
		{
			this.velocity = Vector3.zero;
		}
		if (this.character.isGrounded)
		{
			Vector2 a = Vector2.zero;
			if (this.rotateTouchPad)
			{
				a = this.rotateTouchPad.position;
			}
			else
			{
				Vector3 acceleration = Input.acceleration;
				float num = Mathf.Abs(acceleration.x);
				if (acceleration.z < (float)0 && acceleration.x < (float)0)
				{
					if (num >= this.tiltPositiveYAxis)
					{
						a.y = (num - this.tiltPositiveYAxis) / ((float)1 - this.tiltPositiveYAxis);
					}
					else if (num <= this.tiltNegativeYAxis)
					{
						a.y = -(this.tiltNegativeYAxis - num) / this.tiltNegativeYAxis;
					}
				}
				if (Mathf.Abs(acceleration.y) >= this.tiltXAxisMinimum)
				{
					a.x = -(acceleration.y - this.tiltXAxisMinimum) / ((float)1 - this.tiltXAxisMinimum);
				}
			}
			a.x *= this.rotationSpeed.x;
			a.y *= this.rotationSpeed.y;
			a *= Time.deltaTime;
			this.thisTransform.Rotate((float)0, a.x, (float)0, Space.World);
			this.cameraPivot.Rotate(-a.y, (float)0, (float)0);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class FollowTransform : MonoBehaviour
{
	public Transform targetTransform;

	public bool faceForward;

	private Transform thisTransform;

	public override void Start()
	{
		this.thisTransform = this.transform;
	}

	public override void Update()
	{
		this.thisTransform.position = this.targetTransform.position;
		if (this.faceForward)
		{
			this.thisTransform.forward = this.targetTransform.forward;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Gimbal_Cam_H : MonoBehaviour
{
	public Transform Quadcopter;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (this.Quadcopter.transform.localEulerAngles.z > (float)305 || this.Quadcopter.transform.localEulerAngles.z < (float)55)
		{
			float x = -this.Quadcopter.transform.localEulerAngles.z;
			Vector3 localEulerAngles = this.transform.localEulerAngles;
			float num = localEulerAngles.x = x;
			Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Gimbal_Cam_V : MonoBehaviour
{
	public Transform Quadcopter;

	public Transform joystick_Center;

	private float up_down;

	private float up_down_a;

	private bool reset_cam;

	private bool VR_on;

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
	}

	public override void Update()
	{
		if (this.VR_on)
		{
			float num = -Input.gyro.attitude.eulerAngles.x - (float)90;
			this.up_down_a = Mathf.Clamp(num + this.up_down_a, (float)0, (float)85);
			if (this.Quadcopter.transform.localEulerAngles.x > (float)305 || this.Quadcopter.transform.localEulerAngles.x < (float)55)
			{
				float y = -this.Quadcopter.transform.localEulerAngles.x + this.up_down_a;
				Vector3 localEulerAngles = this.transform.localEulerAngles;
				float num2 = localEulerAngles.y = y;
				Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
			}
		}
		else
		{
			float num = -((Joystick_Camera_FPV)this.joystick_Center.GetComponent(typeof(Joystick_Camera_FPV))).position.y;
			this.up_down_a = Mathf.Clamp(num + this.up_down_a, (float)0, (float)85);
			if (this.reset_cam)
			{
				this.up_down_a = (float)0;
			}
			if (this.Quadcopter.transform.localEulerAngles.x > (float)305 || this.Quadcopter.transform.localEulerAngles.x < (float)55)
			{
				float y2 = -this.Quadcopter.transform.localEulerAngles.x + this.up_down_a;
				Vector3 localEulerAngles2 = this.transform.localEulerAngles;
				float num3 = localEulerAngles2.y = y2;
				Vector3 vector2 = this.transform.localEulerAngles = localEulerAngles2;
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class HomeLock_button : MonoBehaviour
{
	public Transform Quadcopter;

	public Transform butt_off;

	private string adv_set_enabled;

	public Transform adv_set_text;

	private bool VR_on;

	private int height_pos;

	public override void Start()
	{
		this.adv_set_enabled = PlayerPrefs.GetString("Inventory");
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f + this.guiTexture.pixelInset.height * 2.5f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 3)
		{
			float a = 0.5f;
			Color color = this.guiTexture.color;
			float num = color.a = a;
			Color color2 = this.guiTexture.color = color;
			int num2 = 0;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = (float)num2;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		else
		{
			int num4 = 0;
			Color color5 = this.guiTexture.color;
			float num5 = color5.a = (float)num4;
			Color color6 = this.guiTexture.color = color5;
			float a2 = 0.5f;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = a2;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (this.adv_set_enabled != "Subscribed" && this.adv_set_enabled != "Purchase Success")
		{
			float a3 = 0.2f;
			Color color9 = this.butt_off.guiTexture.color;
			float num7 = color9.a = a3;
			Color color10 = this.butt_off.guiTexture.color = color9;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_smart();
				}
			}
		}
		if (Input.GetButtonDown("HomeLock"))
		{
			this.execute_smart();
		}
	}

	public override void execute_smart()
	{
		if (this.adv_set_enabled == "Subscribed" || this.adv_set_enabled == "Purchase Success")
		{
			if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 3)
			{
				((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 1;
			}
			else
			{
				((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 3;
			}
		}
		else if (!this.VR_on)
		{
			this.adv_set_text.gameObject.SetActive(true);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Input_Mapping : MonoBehaviour
{
	public GUISkin customSkin_lowres;

	public GUISkin customSkin_medres;

	public GUISkin customSkin_highres;

	public Transform Controller_L;

	public Transform Controller_R;

	public Transform page_main_T;

	public Transform page_map_T;

	public Transform[] Axis_T;

	public Transform[] Axis_Text;

	public Transform map_Text;

	private GUISkin customSkin;

	private int cont_l_h_i_int;

	private int cont_l_v_i_int;

	private int cont_r_h_i_int;

	private int cont_r_v_i_int;

	private int sl_w;

	private int sl_h;

	private int sl_off_h;

	private int bt_w;

	private int bts_w;

	private float[] Axis_;

	private int Axis_int;

	private string[] Mapped_to_;

	private int Mapped_int;

	private string[] Mapped_to_inv;

	private Rect windowRect;

	private bool toggle_win;

	private bool map_page;

	public float Left_Horizontal_Joy;

	public float Left_Vertical_Joy;

	public float Right_Horizontal_Joy;

	public float Right_Vertical_Joy;

	public Input_Mapping()
	{
		this.Axis_T = new Transform[21];
		this.Axis_Text = new Transform[21];
		this.cont_l_h_i_int = 1;
		this.cont_l_v_i_int = 1;
		this.cont_r_h_i_int = 1;
		this.cont_r_v_i_int = 1;
		this.Axis_ = new float[21];
		this.Mapped_to_ = new string[21];
		this.Mapped_to_inv = new string[21];
	}

	public override void Start()
	{
		for (int i = 0; i < 21; i++)
		{
			this.Mapped_to_[i] = "Un-Assigned";
		}
		this.loadSliders();
		this.windowRect = new Rect(((float)Screen.width - (float)Screen.width * 0.75f) * 0.5f, ((float)Screen.height - (float)Screen.height * 0.75f) * 0.5f, (float)Screen.width * 0.75f, (float)Screen.height * 0.75f);
	}

	public override void Update()
	{
		this.sl_w = (int)((float)Screen.width / 6.4f);
		this.sl_h = (int)((float)Screen.width / 30f);
		this.sl_off_h = (int)((float)Screen.width / 21f);
		this.bt_w = (int)((float)Screen.width / 10f);
		this.bts_w = (int)((float)Screen.width / 9f);
		this.customSkin = this.customSkin_lowres;
		this.Axis_[1] = Input.GetAxis("Horizontal");
		this.Axis_[2] = Input.GetAxis("Vertical");
		this.Axis_[3] = Input.GetAxis("Third_Axis");
		this.Axis_[4] = Input.GetAxis("Fourth_Axis");
		this.Axis_[5] = Input.GetAxis("Fifth_Axis");
		this.Axis_[6] = Input.GetAxis("Sixth_Axis");
		this.Axis_[7] = Input.GetAxis("Seventh_Axis");
		this.Axis_[8] = Input.GetAxis("Eighth_Axis");
		this.Axis_[9] = Input.GetAxis("Ninth_Axis");
		this.Axis_[10] = Input.GetAxis("Tenth_Axis");
		this.Axis_[11] = Input.GetAxis("Eleventh_Axis");
		this.Axis_[12] = Input.GetAxis("Twelveth_Axis");
		this.Axis_[13] = Input.GetAxis("Thirteenth_Axis");
		this.Axis_[14] = Input.GetAxis("Fourteenth_Axis");
		this.Axis_[15] = Input.GetAxis("Fifteenth_Axis");
		this.Axis_[16] = Input.GetAxis("Sixteenth_Axis");
		this.Axis_[17] = Input.GetAxis("Seventeenth_Axis");
		this.Axis_[18] = Input.GetAxis("Eighteenth_Axis");
		this.Axis_[19] = Input.GetAxis("Nineteenth_Axis");
		this.Axis_[20] = Input.GetAxis("Twentyth_Axis");
		for (int i = 1; i < 21; i++)
		{
			((Slider)this.Axis_T[i].gameObject.GetComponent(typeof(Slider))).value = this.Axis_[i];
			((Text)this.Axis_Text[i].gameObject.GetComponent(typeof(Text))).text = this.Mapped_to_[i] + this.Mapped_to_inv[i];
		}
		if (this.map_page)
		{
			float x = Mathf.Lerp(((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)-2500, Time.deltaTime * (float)10);
			Vector2 anchoredPosition = ((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num = anchoredPosition.x = x;
			Vector2 vector = ((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition;
			float x2 = Mathf.Lerp(((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)0, Time.deltaTime * (float)10);
			Vector2 anchoredPosition2 = ((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num2 = anchoredPosition2.x = x2;
			Vector2 vector2 = ((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition2;
			((Text)this.map_Text.gameObject.GetComponent(typeof(Text))).text = this.Mapped_to_[this.Axis_int] + this.Mapped_to_inv[this.Axis_int];
		}
		else
		{
			float x3 = Mathf.Lerp(((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)0, Time.deltaTime * (float)10);
			Vector2 anchoredPosition3 = ((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num3 = anchoredPosition3.x = x3;
			Vector2 vector3 = ((RectTransform)this.page_main_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition3;
			float x4 = Mathf.Lerp(((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)2500, Time.deltaTime * (float)10);
			Vector2 anchoredPosition4 = ((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num4 = anchoredPosition4.x = x4;
			Vector2 vector4 = ((RectTransform)this.page_map_T.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition4;
		}
		for (int j = 0; j < 21; j++)
		{
			if (this.Mapped_to_[j] == "Left / Hor.")
			{
				this.Left_Horizontal_Joy = this.Axis_[j] * (float)this.cont_l_h_i_int;
			}
			if (this.Mapped_to_[j] == "Left / Ver.")
			{
				this.Left_Vertical_Joy = this.Axis_[j] * (float)this.cont_l_v_i_int;
			}
			if (this.Mapped_to_[j] == "Right / Hor.")
			{
				this.Right_Horizontal_Joy = this.Axis_[j] * (float)this.cont_r_h_i_int;
			}
			if (this.Mapped_to_[j] == "Right / Ver.")
			{
				this.Right_Vertical_Joy = this.Axis_[j] * (float)this.cont_r_v_i_int;
			}
		}
		float x5 = -this.Left_Horizontal_Joy * 0.25f;
		Vector3 localPosition = this.Controller_L.localPosition;
		float num5 = localPosition.x = x5;
		Vector3 vector5 = this.Controller_L.localPosition = localPosition;
		float z = this.Left_Vertical_Joy * 0.25f;
		Vector3 localPosition2 = this.Controller_L.localPosition;
		float num6 = localPosition2.z = z;
		Vector3 vector6 = this.Controller_L.localPosition = localPosition2;
		float x6 = -this.Right_Horizontal_Joy * 0.25f;
		Vector3 localPosition3 = this.Controller_R.localPosition;
		float num7 = localPosition3.x = x6;
		Vector3 vector7 = this.Controller_R.localPosition = localPosition3;
		float z2 = this.Right_Vertical_Joy * 0.25f;
		Vector3 localPosition4 = this.Controller_R.localPosition;
		float num8 = localPosition4.z = z2;
		Vector3 vector8 = this.Controller_R.localPosition = localPosition4;
	}

	public override void saveSliders()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Left / Hor.")
			{
				PlayerPrefs.SetInt("Left_Horizontal_Joy", i);
				PlayerPrefs.SetInt("Left_Horizontal_Joy_Inv", this.cont_l_h_i_int);
			}
			if (this.Mapped_to_[i] == "Left / Ver.")
			{
				PlayerPrefs.SetInt("Left_Vertical_Joy", i);
				PlayerPrefs.SetInt("Left_Vertical_Joy_Inv", this.cont_l_v_i_int);
			}
			if (this.Mapped_to_[i] == "Right / Hor.")
			{
				PlayerPrefs.SetInt("Right_Horizontal_Joy", i);
				PlayerPrefs.SetInt("Right_Horizontal_Joy_Inv", this.cont_r_h_i_int);
			}
			if (this.Mapped_to_[i] == "Right / Ver.")
			{
				PlayerPrefs.SetInt("Right_Vertical_Joy", i);
				PlayerPrefs.SetInt("Right_Vertical_Joy_Inv", this.cont_r_v_i_int);
			}
		}
	}

	public override void loadSliders()
	{
		this.Mapped_to_[PlayerPrefs.GetInt("Left_Horizontal_Joy")] = "Left / Hor.";
		this.Mapped_to_[PlayerPrefs.GetInt("Left_Vertical_Joy")] = "Left / Ver.";
		this.Mapped_to_[PlayerPrefs.GetInt("Right_Horizontal_Joy")] = "Right / Hor.";
		this.Mapped_to_[PlayerPrefs.GetInt("Right_Vertical_Joy")] = "Right / Ver.";
		this.cont_l_h_i_int = PlayerPrefs.GetInt("Left_Horizontal_Joy_Inv");
		this.cont_l_v_i_int = PlayerPrefs.GetInt("Left_Vertical_Joy_Inv");
		this.cont_r_h_i_int = PlayerPrefs.GetInt("Right_Horizontal_Joy_Inv");
		this.cont_r_v_i_int = PlayerPrefs.GetInt("Right_Vertical_Joy_Inv");
		if (this.cont_l_h_i_int < 0)
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Left_Horizontal_Joy")] = " / Inv.";
		}
		else
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Left_Horizontal_Joy")] = string.Empty;
		}
		if (this.cont_l_v_i_int < 0)
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Left_Vertical_Joy")] = " / Inv.";
		}
		else
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Left_Vertical_Joy")] = string.Empty;
		}
		if (this.cont_r_h_i_int < 0)
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Right_Horizontal_Joy")] = " / Inv.";
		}
		else
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Right_Horizontal_Joy")] = string.Empty;
		}
		if (this.cont_r_v_i_int < 0)
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Right_Vertical_Joy")] = " / Inv.";
		}
		else
		{
			this.Mapped_to_inv[PlayerPrefs.GetInt("Right_Vertical_Joy")] = string.Empty;
		}
	}

	public override void defaultSliders()
	{
		PlayerPrefs.SetInt("Left_Horizontal_Joy", 1);
		PlayerPrefs.SetInt("Left_Vertical_Joy", 2);
		PlayerPrefs.SetInt("Right_Horizontal_Joy", 3);
		PlayerPrefs.SetInt("Right_Vertical_Joy", 4);
		this.Mapped_to_[5] = "Un-Assigned";
		this.Mapped_to_[6] = "Un-Assigned";
		this.Mapped_to_[7] = "Un-Assigned";
		this.Mapped_to_[8] = "Un-Assigned";
		this.Mapped_to_[9] = "Un-Assigned";
		this.Mapped_to_[10] = "Un-Assigned";
		this.Mapped_to_[11] = "Un-Assigned";
		this.Mapped_to_[12] = "Un-Assigned";
		this.Mapped_to_[13] = "Un-Assigned";
		this.Mapped_to_[14] = "Un-Assigned";
		this.Mapped_to_[15] = "Un-Assigned";
		this.Mapped_to_[16] = "Un-Assigned";
		this.Mapped_to_[17] = "Un-Assigned";
		this.Mapped_to_[18] = "Un-Assigned";
		this.Mapped_to_[19] = "Un-Assigned";
		this.Mapped_to_[20] = "Un-Assigned";
		this.Mapped_to_inv[5] = string.Empty;
		this.Mapped_to_inv[6] = string.Empty;
		this.Mapped_to_inv[7] = string.Empty;
		this.Mapped_to_inv[8] = string.Empty;
		this.Mapped_to_inv[9] = string.Empty;
		this.Mapped_to_inv[10] = string.Empty;
		this.Mapped_to_inv[11] = string.Empty;
		this.Mapped_to_inv[12] = string.Empty;
		this.Mapped_to_inv[13] = string.Empty;
		this.Mapped_to_inv[14] = string.Empty;
		this.Mapped_to_inv[15] = string.Empty;
		this.Mapped_to_inv[16] = string.Empty;
		this.Mapped_to_inv[17] = string.Empty;
		this.Mapped_to_inv[18] = string.Empty;
		this.Mapped_to_inv[19] = string.Empty;
		this.Mapped_to_inv[20] = string.Empty;
		PlayerPrefs.SetInt("Left_Horizontal_Joy_Inv", 1);
		PlayerPrefs.SetInt("Left_Vertical_Joy_Inv", 1);
		PlayerPrefs.SetInt("Right_Horizontal_Joy_Inv", 1);
		PlayerPrefs.SetInt("Right_Vertical_Joy_Inv", -1);
		this.loadSliders();
	}

	public override void back_button()
	{
		this.saveSliders();
		Application.LoadLevel(1);
	}

	public override void axis_button_press_1()
	{
		this.Axis_int = 1;
		this.map_page = true;
	}

	public override void axis_button_press_2()
	{
		this.Axis_int = 2;
		this.map_page = true;
	}

	public override void axis_button_press_3()
	{
		this.Axis_int = 3;
		this.map_page = true;
	}

	public override void axis_button_press_4()
	{
		this.Axis_int = 4;
		this.map_page = true;
	}

	public override void axis_button_press_5()
	{
		this.Axis_int = 5;
		this.map_page = true;
	}

	public override void axis_button_press_6()
	{
		this.Axis_int = 6;
		this.map_page = true;
	}

	public override void axis_button_press_7()
	{
		this.Axis_int = 7;
		this.map_page = true;
	}

	public override void axis_button_press_8()
	{
		this.Axis_int = 8;
		this.map_page = true;
	}

	public override void axis_button_press_9()
	{
		this.Axis_int = 9;
		this.map_page = true;
	}

	public override void axis_button_press_10()
	{
		this.Axis_int = 10;
		this.map_page = true;
	}

	public override void axis_button_press_11()
	{
		this.Axis_int = 11;
		this.map_page = true;
	}

	public override void axis_button_press_12()
	{
		this.Axis_int = 12;
		this.map_page = true;
	}

	public override void axis_button_press_13()
	{
		this.Axis_int = 13;
		this.map_page = true;
	}

	public override void axis_button_press_14()
	{
		this.Axis_int = 14;
		this.map_page = true;
	}

	public override void axis_button_press_15()
	{
		this.Axis_int = 15;
		this.map_page = true;
	}

	public override void axis_button_press_16()
	{
		this.Axis_int = 16;
		this.map_page = true;
	}

	public override void axis_button_press_17()
	{
		this.Axis_int = 17;
		this.map_page = true;
	}

	public override void axis_button_press_18()
	{
		this.Axis_int = 18;
		this.map_page = true;
	}

	public override void axis_button_press_19()
	{
		this.Axis_int = 19;
		this.map_page = true;
	}

	public override void axis_button_press_20()
	{
		this.Axis_int = 20;
		this.map_page = true;
	}

	public override void back_button_map()
	{
		this.map_page = false;
	}

	public override void unassign_button_map()
	{
		this.Mapped_to_[this.Axis_int] = "Un-Assigned";
		this.Mapped_to_inv[this.Axis_int] = string.Empty;
	}

	public override void map_LH()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Left / Hor.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Left / Hor.";
		this.Mapped_to_inv[this.Axis_int] = string.Empty;
		this.cont_l_h_i_int = 1;
		this.Left_Horizontal_Joy = this.Axis_[this.Axis_int];
	}

	public override void map_LV()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Left / Ver.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Left / Ver.";
		this.Mapped_to_inv[this.Axis_int] = string.Empty;
		this.cont_l_v_i_int = 1;
		this.Left_Vertical_Joy = this.Axis_[this.Axis_int];
	}

	public override void map_LHI()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Left / Hor.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Left / Hor.";
		this.Mapped_to_inv[this.Axis_int] = " / Inv.";
		this.cont_l_h_i_int = -1;
		this.Left_Horizontal_Joy = -this.Axis_[this.Axis_int];
	}

	public override void map_LVI()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Left / Ver.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Left / Ver.";
		this.Mapped_to_inv[this.Axis_int] = " / Inv.";
		this.cont_l_v_i_int = -1;
		this.Left_Vertical_Joy = -this.Axis_[this.Axis_int];
	}

	public override void map_RH()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Right / Hor.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Right / Hor.";
		this.Mapped_to_inv[this.Axis_int] = string.Empty;
		this.cont_r_h_i_int = 1;
		this.Right_Horizontal_Joy = this.Axis_[this.Axis_int];
	}

	public override void map_RV()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Right / Ver.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Right / Ver.";
		this.Mapped_to_inv[this.Axis_int] = string.Empty;
		this.cont_r_v_i_int = 1;
		this.Right_Vertical_Joy = this.Axis_[this.Axis_int];
	}

	public override void map_RHI()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Right / Hor.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Right / Hor.";
		this.Mapped_to_inv[this.Axis_int] = " / Inv.";
		this.cont_r_h_i_int = -1;
		this.Right_Horizontal_Joy = -this.Axis_[this.Axis_int];
	}

	public override void map_RVI()
	{
		for (int i = 0; i < 21; i++)
		{
			if (this.Mapped_to_[i] == "Right / Ver.")
			{
				this.Mapped_to_[i] = "Un-Assigned";
				this.Mapped_to_inv[this.Axis_int] = string.Empty;
			}
		}
		this.Mapped_to_[this.Axis_int] = "Right / Ver.";
		this.Mapped_to_inv[this.Axis_int] = " / Inv.";
		this.cont_r_v_i_int = -1;
		this.Right_Vertical_Joy = -this.Axis_[this.Axis_int];
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityScript.Lang;

[RequireComponent(typeof(GUITexture))]
[Serializable]
public class Joystick : MonoBehaviour
{
	[NonSerialized]
	private static Joystick[] joysticks;

	[NonSerialized]
	private static bool enumeratedJoysticks;

	[NonSerialized]
	private static float tapTimeDelta = 0.3f;

	public bool touchPad;

	public Rect touchZone;

	public Vector2 deadZone;

	public bool normalize;

	public Vector2 position;

	public int tapCount;

	public bool joy_throttle;

	public bool joy_right;

	public float throttle_pos;

	public Transform Quad;

	private int input_mode;

	private int cont_status;

	private int lastFingerId;

	private float tapTimeWindow;

	private Vector2 fingerDownPos;

	private float fingerDownTime;

	private float firstDeltaTime;

	private GUITexture gui;

	private Rect defaultRect;

	private Boundary guiBoundary;

	private Vector2 guiTouchOffset;

	private Vector2 guiCenter;

	public Joystick()
	{
		this.deadZone = Vector2.zero;
		this.lastFingerId = -1;
		this.firstDeltaTime = 0.5f;
		this.guiBoundary = new Boundary();
	}

	public override void Start()
	{
		this.input_mode = PlayerPrefs.GetInt("Input_mode");
		int @int = PlayerPrefs.GetInt("Flying_Mode");
		this.cont_status = PlayerPrefs.GetInt("Controller_Status");
		if (this.cont_status == 1)
		{
			this.transform.gameObject.SetActive(false);
		}
		if (this.input_mode == 5 && !this.joy_throttle)
		{
			this.transform.gameObject.SetActive(false);
		}
		if (this.input_mode == 1)
		{
			this.joy_throttle = !this.joy_throttle;
		}
		if (this.input_mode == 3)
		{
			this.joy_throttle = !this.joy_throttle;
		}
		if (Screen.width < 1024)
		{
			this.guiTexture.pixelInset = new Rect((float)10, (float)10, (float)200, (float)200);
		}
		else if (Screen.width > 1500)
		{
			this.guiTexture.pixelInset = new Rect((float)10, (float)10, (float)400, (float)400);
		}
		else
		{
			this.guiTexture.pixelInset = new Rect((float)10, (float)10, (float)300, (float)300);
		}
		if (this.joy_throttle && @int != 3)
		{
			this.position.y = (float)-1;
		}
		this.gui = (GUITexture)this.GetComponent(typeof(GUITexture));
		this.defaultRect = this.gui.pixelInset;
		if (this.joy_right)
		{
			float x = (float)1 - (this.gui.pixelInset.width + this.gui.pixelInset.x * (float)2) / UnityBuiltins.parseFloat(Screen.width);
			Vector3 vector = this.transform.position;
			float num = vector.x = x;
			Vector3 vector2 = this.transform.position = vector;
		}
		this.defaultRect.x = this.defaultRect.x + this.transform.position.x * (float)Screen.width;
		this.defaultRect.y = this.defaultRect.y + this.transform.position.y * (float)Screen.height;
		float x2 = (float)0;
		Vector3 vector3 = this.transform.position;
		float num2 = vector3.x = x2;
		Vector3 vector4 = this.transform.position = vector3;
		float y = (float)0;
		Vector3 vector5 = this.transform.position;
		float num3 = vector5.y = y;
		Vector3 vector6 = this.transform.position = vector5;
		if (this.touchPad)
		{
			if (this.gui.texture)
			{
				this.touchZone = this.defaultRect;
			}
		}
		else
		{
			this.guiTouchOffset.x = this.defaultRect.width * 0.5f;
			this.guiTouchOffset.y = this.defaultRect.height * 0.5f;
			this.guiCenter.x = this.defaultRect.x + this.guiTouchOffset.x;
			this.guiCenter.y = this.defaultRect.y + this.guiTouchOffset.y;
			this.guiBoundary.min.x = this.defaultRect.x - this.guiTouchOffset.x;
			this.guiBoundary.max.x = this.defaultRect.x + this.guiTouchOffset.x;
			this.guiBoundary.min.y = this.defaultRect.y - this.guiTouchOffset.y;
			this.guiBoundary.max.y = this.defaultRect.y + this.guiTouchOffset.y;
		}
	}

	public override void Disable()
	{
		this.gameObject.SetActive(false);
		Joystick.enumeratedJoysticks = false;
	}

	public override void ResetJoystick()
	{
		this.gui.pixelInset = this.defaultRect;
		this.lastFingerId = -1;
		if (this.joy_throttle && !((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			this.position.x = (float)0;
			this.fingerDownPos = Vector2.zero;
			this.throttle_pos = this.position.y;
		}
		else
		{
			this.position = Vector2.zero;
			this.fingerDownPos = Vector2.zero;
		}
		if (this.touchPad)
		{
			float a = 0.025f;
			Color color = this.gui.color;
			float num = color.a = a;
			Color color2 = this.gui.color = color;
		}
	}

	public override bool IsFingerDown()
	{
		return this.lastFingerId != -1;
	}

	public override void LatchedFinger(int fingerId)
	{
		if (this.lastFingerId == fingerId)
		{
			this.ResetJoystick();
		}
	}

	public override void Update()
	{
		if (!Joystick.enumeratedJoysticks)
		{
			Joystick.joysticks = (((Joystick[])UnityEngine.Object.FindObjectsOfType(typeof(Joystick))) as Joystick[]);
			Joystick.enumeratedJoysticks = true;
		}
		int touchCount = Input.touchCount;
		if (this.tapTimeWindow > (float)0)
		{
			this.tapTimeWindow -= Time.deltaTime;
		}
		else
		{
			this.tapCount = 0;
		}
		if (touchCount == 0)
		{
			this.ResetJoystick();
		}
		else
		{
			for (int i = 0; i < touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				Vector2 vector = touch.position - this.guiTouchOffset;
				bool flag = false;
				if (this.touchPad)
				{
					if (this.touchZone.Contains(touch.position))
					{
						flag = true;
					}
				}
				else if (this.gui.HitTest(touch.position))
				{
					flag = true;
				}
				if (flag && (this.lastFingerId == -1 || this.lastFingerId != touch.fingerId))
				{
					if (this.touchPad)
					{
						float a = 0.15f;
						Color color = this.gui.color;
						float num = color.a = a;
						Color color2 = this.gui.color = color;
						this.lastFingerId = touch.fingerId;
						this.fingerDownPos = touch.position;
						this.fingerDownTime = Time.time;
					}
					this.lastFingerId = touch.fingerId;
					if (this.tapTimeWindow > (float)0)
					{
						this.tapCount++;
					}
					else
					{
						this.tapCount = 1;
						this.tapTimeWindow = Joystick.tapTimeDelta;
					}
					int j = 0;
					Joystick[] array = Joystick.joysticks;
					int length = array.Length;
					while (j < length)
					{
						if (array[j] != this)
						{
							array[j].LatchedFinger(touch.fingerId);
						}
						j++;
					}
				}
				if (this.lastFingerId == touch.fingerId)
				{
					if (touch.tapCount > this.tapCount)
					{
						this.tapCount = touch.tapCount;
					}
					if (this.touchPad)
					{
						this.position.x = Mathf.Clamp((touch.position.x - this.fingerDownPos.x) / (this.touchZone.width / (float)2), (float)-1, (float)1);
						if (this.joy_throttle && !((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
						{
							this.position.y = Mathf.Clamp((touch.position.y - this.fingerDownPos.y) / (this.touchZone.height / (float)2) + this.throttle_pos, (float)-1, (float)1);
						}
						else
						{
							this.position.y = Mathf.Clamp((touch.position.y - this.fingerDownPos.y) / (this.touchZone.height / (float)2), (float)-1, (float)1);
						}
					}
					else
					{
						float x = Mathf.Clamp(vector.x, this.guiBoundary.min.x, this.guiBoundary.max.x);
						Rect pixelInset = this.gui.pixelInset;
						float num2 = pixelInset.x = x;
						Rect rect = this.gui.pixelInset = pixelInset;
						float y = Mathf.Clamp(vector.y, this.guiBoundary.min.y, this.guiBoundary.max.y);
						Rect pixelInset2 = this.gui.pixelInset;
						float num3 = pixelInset2.y = y;
						Rect rect2 = this.gui.pixelInset = pixelInset2;
					}
					if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
					{
						this.ResetJoystick();
					}
				}
			}
		}
		if (!this.touchPad)
		{
			this.position.x = (this.gui.pixelInset.x + this.guiTouchOffset.x - this.guiCenter.x) / this.guiTouchOffset.x;
			this.position.y = (this.gui.pixelInset.y + this.guiTouchOffset.y - this.guiCenter.y) / this.guiTouchOffset.y;
		}
		float num4 = Mathf.Abs(this.position.x);
		float num5 = Mathf.Abs(this.position.y);
		if (num4 < this.deadZone.x)
		{
			this.position.x = (float)0;
		}
		else if (this.normalize)
		{
			this.position.x = Mathf.Sign(this.position.x) * (num4 - this.deadZone.x) / ((float)1 - this.deadZone.x);
		}
		if (num5 < this.deadZone.y)
		{
			this.position.y = (float)0;
		}
		else if (this.normalize)
		{
			this.position.y = Mathf.Sign(this.position.y) * (num5 - this.deadZone.y) / ((float)1 - this.deadZone.y);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class Joystick_Cam_Pos : MonoBehaviour
{
	public bool is_cam_right;

	private int pixel_width;

	private int input_mode;

	private int cont_status;

	public override void Start()
	{
		this.input_mode = PlayerPrefs.GetInt("Input_mode");
		this.cont_status = PlayerPrefs.GetInt("Controller_Status");
		if (this.cont_status == 1)
		{
			this.transform.gameObject.SetActive(false);
		}
		if (this.input_mode == 5 && this.is_cam_right)
		{
			this.transform.gameObject.SetActive(false);
		}
		if (Screen.width < 1024)
		{
			this.pixel_width = 200;
		}
		else if (Screen.width > 1500)
		{
			this.pixel_width = 400;
		}
		else
		{
			this.pixel_width = 300;
		}
		if (this.is_cam_right)
		{
			float x = (float)1 - (float)this.pixel_width / UnityBuiltins.parseFloat(Screen.width);
			Rect rect = this.transform.camera.rect;
			float num = rect.x = x;
			Rect rect2 = this.transform.camera.rect = rect;
		}
		float width = (float)this.pixel_width / UnityBuiltins.parseFloat(Screen.width);
		Rect rect3 = this.transform.camera.rect;
		float num2 = rect3.width = width;
		Rect rect4 = this.transform.camera.rect = rect3;
		float height = (float)this.pixel_width / UnityBuiltins.parseFloat(Screen.height);
		Rect rect5 = this.transform.camera.rect;
		float num3 = rect5.height = height;
		Rect rect6 = this.transform.camera.rect = rect5;
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(GUITexture))]
[Serializable]
public class Joystick_Camera_FPV : MonoBehaviour
{
	[NonSerialized]
	private static Joystick[] joysticks;

	[NonSerialized]
	private static bool enumeratedJoysticks;

	[NonSerialized]
	private static float tapTimeDelta = 0.3f;

	public bool touchPad;

	public Rect touchZone;

	public Vector2 deadZone;

	public bool normalize;

	public Vector2 position;

	public int tapCount;

	public Vector2 position_pos;

	private int lastFingerId;

	private float tapTimeWindow;

	private Vector2 fingerDownPos;

	private float fingerDownTime;

	private float firstDeltaTime;

	private GUITexture gui;

	private Rect defaultRect;

	private Boundary guiBoundary;

	private Vector2 guiTouchOffset;

	private Vector2 guiCenter;

	public bool reset_cam;

	public Joystick_Camera_FPV()
	{
		this.deadZone = Vector2.zero;
		this.position_pos = Vector2.zero;
		this.lastFingerId = -1;
		this.firstDeltaTime = 0.5f;
		this.guiBoundary = new Boundary();
	}

	public override void Start()
	{
		if (Screen.width < 1024)
		{
			this.guiTexture.pixelInset = new Rect((float)-100, (float)-100, (float)200, (float)200);
		}
		else if (Screen.width > 1500)
		{
			this.guiTexture.pixelInset = new Rect((float)-200, (float)-200, (float)400, (float)400);
		}
		else
		{
			this.guiTexture.pixelInset = new Rect((float)-150, (float)-150, (float)300, (float)300);
		}
		this.gui = (GUITexture)this.GetComponent(typeof(GUITexture));
		this.defaultRect = this.gui.pixelInset;
		this.defaultRect.x = this.defaultRect.x + this.transform.position.x * (float)Screen.width;
		this.defaultRect.y = this.defaultRect.y + this.transform.position.y * (float)Screen.height;
		float x = (float)0;
		Vector3 vector = this.transform.position;
		float num = vector.x = x;
		Vector3 vector2 = this.transform.position = vector;
		float y = (float)0;
		Vector3 vector3 = this.transform.position;
		float num2 = vector3.y = y;
		Vector3 vector4 = this.transform.position = vector3;
		if (this.touchPad)
		{
			if (this.gui.texture)
			{
				this.touchZone = this.defaultRect;
			}
		}
		else
		{
			this.guiTouchOffset.x = this.defaultRect.width * 0.5f;
			this.guiTouchOffset.y = this.defaultRect.height * 0.5f;
			this.guiCenter.x = this.defaultRect.x + this.guiTouchOffset.x;
			this.guiCenter.y = this.defaultRect.y + this.guiTouchOffset.y;
			this.guiBoundary.min.x = this.defaultRect.x - this.guiTouchOffset.x;
			this.guiBoundary.max.x = this.defaultRect.x + this.guiTouchOffset.x;
			this.guiBoundary.min.y = this.defaultRect.y - this.guiTouchOffset.y;
			this.guiBoundary.max.y = this.defaultRect.y + this.guiTouchOffset.y;
		}
	}

	public override void Disable()
	{
		this.gameObject.SetActive(false);
		Joystick_Camera_FPV.enumeratedJoysticks = false;
	}

	public override void ResetJoystick()
	{
		this.gui.pixelInset = this.defaultRect;
		this.lastFingerId = -1;
		this.fingerDownPos = Vector2.zero;
		this.position.y = (float)0;
		this.position.x = (float)0;
		if (this.touchPad)
		{
			float a = 0.025f;
			Color color = this.gui.color;
			float num = color.a = a;
			Color color2 = this.gui.color = color;
		}
	}

	public override bool IsFingerDown()
	{
		return this.lastFingerId != -1;
	}

	public override void LatchedFinger(int fingerId)
	{
		if (this.lastFingerId == fingerId)
		{
			this.ResetJoystick();
		}
	}

	public override void Update()
	{
		if (this.tapCount == 2)
		{
			this.reset_cam = true;
		}
		else
		{
			this.reset_cam = false;
		}
		if (!Joystick_Camera_FPV.enumeratedJoysticks)
		{
			Joystick_Camera_FPV.joysticks = (((Joystick[])UnityEngine.Object.FindObjectsOfType(typeof(Joystick))) as Joystick[]);
			Joystick_Camera_FPV.enumeratedJoysticks = true;
		}
		int touchCount = Input.touchCount;
		if (this.tapTimeWindow > (float)0)
		{
			this.tapTimeWindow -= Time.deltaTime;
		}
		else
		{
			this.tapCount = 0;
		}
		if (touchCount == 0)
		{
			this.ResetJoystick();
		}
		else
		{
			for (int i = 0; i < touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				Vector2 vector = touch.position - this.guiTouchOffset;
				bool flag = false;
				if (this.touchPad)
				{
					if (this.touchZone.Contains(touch.position))
					{
						flag = true;
					}
				}
				else if (this.gui.HitTest(touch.position))
				{
					flag = true;
				}
				if (flag && (this.lastFingerId == -1 || this.lastFingerId != touch.fingerId))
				{
					if (this.touchPad)
					{
						float a = 0.05f;
						Color color = this.gui.color;
						float num = color.a = a;
						Color color2 = this.gui.color = color;
						this.lastFingerId = touch.fingerId;
						this.fingerDownPos = touch.position;
						this.fingerDownTime = Time.time;
					}
					this.lastFingerId = touch.fingerId;
					if (this.tapTimeWindow > (float)0)
					{
						this.tapCount++;
					}
					else
					{
						this.tapCount = 1;
						this.tapTimeWindow = Joystick_Camera_FPV.tapTimeDelta;
					}
					int j = 0;
					Joystick[] array = Joystick_Camera_FPV.joysticks;
					int length = array.Length;
					while (j < length)
					{
						if (array[j] != this)
						{
							array[j].LatchedFinger(touch.fingerId);
						}
						j++;
					}
				}
				if (this.lastFingerId == touch.fingerId)
				{
					if (touch.tapCount > this.tapCount)
					{
						this.tapCount = touch.tapCount;
					}
					if (this.touchPad)
					{
						this.position.x = Mathf.Clamp((touch.position.x - this.fingerDownPos.x) / (this.touchZone.width / (float)2), (float)-1, (float)1);
						this.position.y = Mathf.Clamp((touch.position.y - this.fingerDownPos.y) / (this.touchZone.height / (float)2), (float)-1, (float)1);
					}
					else
					{
						float x = Mathf.Clamp(vector.x, this.guiBoundary.min.x, this.guiBoundary.max.x);
						Rect pixelInset = this.gui.pixelInset;
						float num2 = pixelInset.x = x;
						Rect rect = this.gui.pixelInset = pixelInset;
						float y = Mathf.Clamp(vector.y, this.guiBoundary.min.y, this.guiBoundary.max.y);
						Rect pixelInset2 = this.gui.pixelInset;
						float num3 = pixelInset2.y = y;
						Rect rect2 = this.gui.pixelInset = pixelInset2;
					}
					if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
					{
						this.ResetJoystick();
					}
				}
			}
		}
		if (!this.touchPad)
		{
			this.position.x = (this.gui.pixelInset.x + this.guiTouchOffset.x - this.guiCenter.x) / this.guiTouchOffset.x;
			this.position.y = (this.gui.pixelInset.y + this.guiTouchOffset.y - this.guiCenter.y) / this.guiTouchOffset.y;
		}
		float num4 = Mathf.Abs(this.position.x);
		float num5 = Mathf.Abs(this.position.y);
		if (num4 < this.deadZone.x)
		{
			this.position.x = (float)0;
		}
		else if (this.normalize)
		{
			this.position.x = Mathf.Sign(this.position.x) * (num4 - this.deadZone.x) / ((float)1 - this.deadZone.x);
		}
		if (num5 < this.deadZone.y)
		{
			this.position.y = (float)0;
		}
		else if (this.normalize)
		{
			this.position.y = Mathf.Sign(this.position.y) * (num5 - this.deadZone.y) / ((float)1 - this.deadZone.y);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class joystick_movement_f_b : MonoBehaviour
{
	public Transform joystick;

	public override void Start()
	{
	}

	public override void Update()
	{
		float y = ((Joystick)this.joystick.GetComponent(typeof(Joystick))).position.x * (float)20;
		Vector3 localEulerAngles = this.transform.localEulerAngles;
		float num = localEulerAngles.y = y;
		Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class joystick_movement_L_R : MonoBehaviour
{
	public Transform joystick;

	public override void Start()
	{
	}

	public override void Update()
	{
		float x = ((Joystick)this.joystick.GetComponent(typeof(Joystick))).position.y * (float)20;
		Vector3 localEulerAngles = this.transform.localEulerAngles;
		float num = localEulerAngles.x = x;
		Vector3 vector = this.transform.localEulerAngles = localEulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Landing_Rect : MonoBehaviour
{
	private float landtime;

	private bool land_coll;

	public bool coll_stay_check;

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void OnTriggerStay(Collider other)
	{
		if (!this.coll_stay_check)
		{
			this.landtime = Time.time + (float)1;
			this.coll_stay_check = true;
		}
		if (Time.time > this.landtime)
		{
			this.land_coll = true;
		}
	}

	public override void OnTriggerExit(Collider other)
	{
		this.coll_stay_check = false;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Move_Human_Cam : MonoBehaviour
{
	public Transform Joy_in;

	public Transform Cam_rot;

	public float speed_mult;

	public float rotationDamping;

	public Transform current_cam;

	private float sideways;

	private float front_back;

	private float cam_rotate_1;

	private float cam_rotate_2;

	private int camera_selected;

	public bool acc_move;

	public Move_Human_Cam()
	{
		this.speed_mult = 0.1f;
		this.rotationDamping = 3f;
	}

	public override void Start()
	{
		this.acc_move = false;
	}

	public override void LateUpdate()
	{
		this.camera_selected = ((Camera_GUI_Change_button)this.current_cam.GetComponent(typeof(Camera_GUI_Change_button))).cam_sel;
		if (this.camera_selected == 0)
		{
			if (this.acc_move)
			{
				this.front_back = Input.acceleration.y + 0.4f;
				this.sideways = Input.acceleration.x;
			}
			else
			{
				this.sideways = ((Joystick_Camera_FPV)this.Joy_in.GetComponent(typeof(Joystick_Camera_FPV))).position.x;
				this.front_back = ((Joystick_Camera_FPV)this.Joy_in.GetComponent(typeof(Joystick_Camera_FPV))).position.y;
			}
			this.rigidbody.AddRelativeForce(this.sideways * this.speed_mult, (float)0, this.front_back * this.speed_mult);
			float y = this.Cam_rot.transform.eulerAngles.y;
			Vector3 eulerAngles = this.transform.eulerAngles;
			float num = eulerAngles.y = y;
			Vector3 vector = this.transform.eulerAngles = eulerAngles;
			float num2 = this.transform.eulerAngles.y;
			float y2 = this.Cam_rot.eulerAngles.y;
			num2 = Mathf.LerpAngle(num2, y2, this.rotationDamping * Time.deltaTime);
			Quaternion quaternion = Quaternion.Euler((float)0, num2, (float)0);
			float y3 = num2;
			Vector3 eulerAngles2 = this.transform.eulerAngles;
			float num3 = eulerAngles2.y = y3;
			Vector3 vector2 = this.transform.eulerAngles = eulerAngles2;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Never_show : MonoBehaviour
{
	public Transform Text_pro;

	public Transform advertise_control;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.Text_pro.gameObject.SetActive(false);
					if (!((advertise)this.advertise_control.GetComponent(typeof(advertise))).display_default)
					{
						PlayerPrefs.SetInt("Pro_Text_Show_net", 1);
					}
					else
					{
						PlayerPrefs.SetInt("Pro_Text_Show", 1);
					}
				}
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class ObliqueNear : MonoBehaviour
{
	public Transform plane;

	public override Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
	{
		Vector4 b = projection.inverse * new Vector4(Mathf.Sign(clipPlane.x), Mathf.Sign(clipPlane.y), 1f, 1f);
		Vector4 vector = clipPlane * (2f / Vector4.Dot(clipPlane, b));
		projection[2] = vector.x - projection[3];
		projection[6] = vector.y - projection[7];
		projection[10] = vector.z - projection[11];
		projection[14] = vector.w - projection[15];
		return projection;
	}

	public override void OnPreCull()
	{
		Matrix4x4 projectionMatrix = this.camera.projectionMatrix;
		Matrix4x4 worldToCameraMatrix = this.camera.worldToCameraMatrix;
		Vector3 rhs = worldToCameraMatrix.MultiplyPoint(this.plane.position);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(-Vector3.up);
		vector.Normalize();
		Vector4 clipPlane = vector;
		clipPlane.w = -Vector3.Dot(vector, rhs);
		this.camera.projectionMatrix = this.CalculateObliqueMatrix(projectionMatrix, clipPlane);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Pass_through_Rect : MonoBehaviour
{
	public bool Pass_th_Coll;

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	public override void OnTriggerEnter(Collider other)
	{
		this.Pass_th_Coll = true;
	}

	public override void OnTriggerExit(Collider other)
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[Serializable]
public class PlayerRelativeControl : MonoBehaviour
{
	public Joystick moveJoystick;

	public Joystick rotateJoystick;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	public PlayerRelativeControl()
	{
		this.forwardSpeed = (float)4;
		this.backwardSpeed = (float)1;
		this.sidestepSpeed = (float)1;
		this.jumpSpeed = (float)8;
		this.inAirMultiplier = 0.25f;
		this.rotationSpeed = new Vector2((float)50, (float)25);
	}

	public override void Start()
	{
		this.thisTransform = (Transform)this.GetComponent(typeof(Transform));
		this.character = (CharacterController)this.GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if (gameObject)
		{
			this.thisTransform.position = gameObject.transform.position;
		}
	}

	public override void OnEndGame()
	{
		this.moveJoystick.Disable();
		this.rotateJoystick.Disable();
		this.enabled = false;
	}

	public override void Update()
	{
		Vector3 vector = this.thisTransform.TransformDirection(new Vector3(this.moveJoystick.position.x, (float)0, this.moveJoystick.position.y));
		vector.y = (float)0;
		vector.Normalize();
		Vector3 zero = Vector3.zero;
		Vector2 vector2 = new Vector2(Mathf.Abs(this.moveJoystick.position.x), Mathf.Abs(this.moveJoystick.position.y));
		if (vector2.y > vector2.x)
		{
			if (this.moveJoystick.position.y > (float)0)
			{
				vector *= this.forwardSpeed * vector2.y;
			}
			else
			{
				vector *= this.backwardSpeed * vector2.y;
				zero.z = this.moveJoystick.position.y * 0.75f;
			}
		}
		else
		{
			vector *= this.sidestepSpeed * vector2.x;
			zero.x = -this.moveJoystick.position.x * 0.5f;
		}
		if (this.character.isGrounded)
		{
			if (this.rotateJoystick.tapCount == 2)
			{
				this.velocity = this.character.velocity;
				this.velocity.y = this.jumpSpeed;
			}
		}
		else
		{
			this.velocity.y = this.velocity.y + Physics.gravity.y * Time.deltaTime;
			zero.z = -this.jumpSpeed * 0.25f;
			vector.x *= this.inAirMultiplier;
			vector.z *= this.inAirMultiplier;
		}
		vector += this.velocity;
		vector += Physics.gravity;
		vector *= Time.deltaTime;
		this.character.Move(vector);
		if (this.character.isGrounded)
		{
			this.velocity = Vector3.zero;
		}
		Vector3 localPosition = this.cameraPivot.localPosition;
		localPosition.x = Mathf.SmoothDamp(localPosition.x, zero.x, ref this.cameraVelocity.x, 0.3f);
		localPosition.z = Mathf.SmoothDamp(localPosition.z, zero.z, ref this.cameraVelocity.z, 0.5f);
		this.cameraPivot.localPosition = localPosition;
		if (this.character.isGrounded)
		{
			Vector2 a = this.rotateJoystick.position;
			a.x *= this.rotationSpeed.x;
			a.y *= this.rotationSpeed.y;
			a *= Time.deltaTime;
			this.thisTransform.Rotate((float)0, a.x, (float)0, Space.World);
			this.cameraPivot.Rotate(a.y, (float)0, (float)0);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Position_Hold_button : MonoBehaviour
{
	public Transform Quadcopter;

	public Transform butt_off;

	private string adv_set_enabled;

	public Transform adv_set_text;

	private bool VR_on;

	private int height_pos;

	public override void Start()
	{
		this.adv_set_enabled = PlayerPrefs.GetString("Inventory");
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).GPS_mode)
		{
			float a = 0.5f;
			Color color = this.guiTexture.color;
			float num = color.a = a;
			Color color2 = this.guiTexture.color = color;
			int num2 = 0;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = (float)num2;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		else
		{
			int num4 = 0;
			Color color5 = this.guiTexture.color;
			float num5 = color5.a = (float)num4;
			Color color6 = this.guiTexture.color = color5;
			float a2 = 0.5f;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = a2;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (this.adv_set_enabled != "Subscribed" && this.adv_set_enabled != "Purchase Success")
		{
			float a3 = 0.2f;
			Color color9 = this.butt_off.guiTexture.color;
			float num7 = color9.a = a3;
			Color color10 = this.butt_off.guiTexture.color = color9;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_smart();
				}
			}
		}
		if (Input.GetButtonDown("PosHold"))
		{
			this.execute_smart();
		}
	}

	public override void execute_smart()
	{
		if (this.adv_set_enabled == "Subscribed" || this.adv_set_enabled == "Purchase Success")
		{
			((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).GPS_mode = !((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).GPS_mode;
		}
		else if (!this.VR_on)
		{
			this.adv_set_text.gameObject.SetActive(true);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Prop : MonoBehaviour
{
	public int coll;

	public int coll_back;

	public float coll_time;

	public int count;

	private int scene_selected;

	private int Trial_Time_1;

	private int Trial_Time_2;

	public override void Start()
	{
		this.coll = 1;
		this.coll_back = 0;
		this.coll_time = (float)0;
		this.count = 0;
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
	}

	public override void Update()
	{
	}

	public override void LateUpdate()
	{
		if (this.coll_back == 1)
		{
			this.transform.renderer.enabled = false;
			if (this.count == 0)
			{
				this.coll_time = Time.time + (float)5;
				this.count++;
			}
			if (Time.time > this.coll_time)
			{
				if (this.scene_selected == 1 && this.Trial_Time_1 < 120)
				{
					PlayerPrefs.SetInt("Scene_Try_Time_S1", (int)((float)this.Trial_Time_1 + Time.time));
				}
				if (this.scene_selected == 2 && this.Trial_Time_2 < 120)
				{
					PlayerPrefs.SetInt("Scene_Try_Time_S2", (int)((float)this.Trial_Time_2 + Time.time));
				}
				Application.LoadLevel(0);
			}
		}
	}

	public override void OnTriggerEnter(Collider other)
	{
		if (Time.time > (float)2 && !other.gameObject.CompareTag("Challenge"))
		{
			this.coll = 0;
		}
	}

	public override void OnTriggerExit(Collider other)
	{
		if (Time.time > (float)2 && this.coll_back == 0)
		{
			this.coll = 1;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Prop_rotate_Setting_page : MonoBehaviour
{
	public bool Flip_rotate_direction;

	public override void Start()
	{
	}

	public override void FixedUpdate()
	{
		if (this.Flip_rotate_direction)
		{
			this.transform.Rotate((float)0, (float)0, (float)-10);
		}
		else
		{
			this.transform.Rotate((float)0, (float)0, (float)10);
		}
		int num = 1;
		Color color = this.renderer.materials[1].color;
		float num2 = color.a = (float)num;
		Color color2 = this.renderer.materials[1].color = color;
		int num3 = 0;
		Color color3 = this.renderer.materials[0].color;
		float num4 = color3.a = (float)num3;
		Color color4 = this.renderer.materials[0].color = color3;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Quad_Dynamics : MonoBehaviour
{
	public float in_throttle;

	public float in_pitch;

	public float in_roll;

	public float in_yaw;

	public float control_senstivity;

	public float pitch;

	public float roll;

	public float yaw;

	public Transform centre_of_gravity;

	public Vector3 gravity;

	public float auto_stabilize_senstivity;

	public override void Start()
	{
		this.control_senstivity = 0.2f;
		this.auto_stabilize_senstivity = 0.002f;
		this.gravity = new Vector3((float)0, -9.8f, (float)0);
	}

	public override void FixedUpdate()
	{
		this.in_throttle = -Input.GetAxis("Throttle") + (float)1;
		this.in_pitch = Input.GetAxis("Vertical");
		this.in_roll = -Input.GetAxis("Horizontal");
		this.in_yaw = Input.GetAxis("Yaw");
		this.rigidbody.AddRelativeForce((float)0, this.in_throttle * (float)6, (float)0);
		this.rigidbody.AddRelativeTorque(this.in_pitch * this.control_senstivity, (float)0, (float)0);
		this.rigidbody.AddRelativeTorque((float)0, (float)0, this.in_roll * this.control_senstivity);
		this.rigidbody.AddRelativeTorque((float)0, this.in_yaw * this.control_senstivity, (float)0);
		if (this.transform.eulerAngles.x >= (float)180)
		{
			this.pitch = this.transform.eulerAngles.x - (float)360;
		}
		else
		{
			this.pitch = this.transform.eulerAngles.x;
		}
		if (this.transform.eulerAngles.z >= (float)180)
		{
			this.roll = this.transform.eulerAngles.z - (float)360;
		}
		else
		{
			this.roll = this.transform.eulerAngles.z;
		}
		this.rigidbody.AddRelativeTorque(-(this.auto_stabilize_senstivity * this.pitch), (float)0, (float)0);
		this.rigidbody.AddRelativeTorque((float)0, (float)0, -(this.auto_stabilize_senstivity * this.roll));
		if (this.in_yaw == (float)0)
		{
			this.rigidbody.AddRelativeTorque((float)0, -(this.rigidbody.angularVelocity.normalized.y * 0.1f), (float)0);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Propeller : MonoBehaviour
{
	public override void Start()
	{
	}

	public override void Update()
	{
		this.transform.Rotate((float)0, (float)0, -(Input.GetAxis("Throttle") * (float)100));
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Quad_Dynamics_independent_propeller : MonoBehaviour
{
	public float in_throttle;

	public float in_pitch;

	public float in_roll;

	public float in_yaw;

	public float control_senstivity;

	public float control_senstive_yaw;

	public float max_TA;

	public bool CSC_on;

	public bool CSC_once;

	public bool CSC_time_once;

	public float CSC_time;

	private bool manual_mode_toggle;

	private bool lights_flip_toggle;

	public float roll_pitch_P;

	public float roll_pitch_I;

	public float roll_pitch_D;

	public float yaw_P;

	public float yaw_I;

	public float yaw_D;

	public Transform joystick_left;

	public Transform joystick_right;

	public Transform particle_effects;

	public float joy_in_throttle;

	private float joy_in_pitch;

	private float joy_in_roll;

	private float joy_in_yaw;

	private float ang_drag;

	private float aero_Drag;

	public float Left_Hor_Joy;

	public float Left_Ver_Joy;

	public float Right_Hor_Joy;

	public float Right_Ver_Joy;

	private float pitch_balance;

	private float roll_balance;

	private string[] controller;

	private int controller_int;

	private float[] Axis_;

	private int enable_controller;

	private int controller_l_h_int;

	private int controller_l_v_int;

	private int controller_r_h_int;

	private int controller_r_v_int;

	private int controller_l_h_i_int;

	private int controller_l_v_i_int;

	private int controller_r_h_i_int;

	private int controller_r_v_i_int;

	public float pitch;

	public float roll;

	public float yaw;

	public float angle_move;

	public float angle_move_cal;

	public float return_home_angle;

	public int flying_mode;

	public int flying_mode_set;

	public float previous_angle_y;

	public float previous_angle_z;

	public bool flip;

	public float torque_multiplier;

	public float dynamic_thrust_velocity;

	public float motor_torque_front_left;

	public float motor_torque_front_right;

	public float motor_torque_rear_left;

	public float motor_torque_rear_right;

	public bool altitude_hold;

	public float vertical_hold;

	public float level_flight;

	public float vertical_velocity;

	public float auto_stabilize_senstivity;

	public float auto_stabilize_senst;

	public float auto_stabilize_senst_set;

	public float control_senstivity_set;

	public float max_TA_set;

	public float roll_pitch_P_set;

	public float roll_pitch_D_set;

	public float Stabilize_roll;

	public float Stabilize_pitch;

	public float pitch_multiplier;

	public float volume_multiplier;

	public Transform home_point;

	public Transform home_point_hor;

	public float home_distance_hor;

	public float max_height_reached;

	public float GPS_pos_angle;

	public Transform GPS_pos;

	public float GPS_pos_dist;

	public float GPS_pos_vel_d;

	public Transform GPS_pos_old;

	public float old_time;

	public float old_time_2;

	public bool once;

	public bool once_2;

	public float pitch_roll_magnitude;

	public bool GPS_mode;

	public bool on_ground;

	public float flip_angle;

	public float Ground_wait_time;

	public bool once_5;

	public bool return_height;

	public float hor_vel;

	public bool going_down;

	public int coll_front_left;

	public int coll_front_right;

	public int coll_rear_left;

	public int coll_rear_right;

	public int high_speed_collision;

	public Transform controller_location;

	public int max_range;

	public Transform warning_display;

	public Transform cam_human;

	public Transform mountains;

	public float distanceToGround;

	public float ground_effect_multiplier;

	public Transform Ground_effects;

	public Transform Camera_Gimbal_Set;

	private string[] text_display;

	private float torque_mult_vfx;

	public Transform[] quads;

	public int quad_selected;

	private int input_mode;

	private int scene_selected;

	public Transform home_loc_point;

	public bool smart_mode;

	public int sm_mode;

	public int counti;

	public int countii;

	public float level_return_height;

	public Transform prop_front_left;

	public Transform prop_front_right;

	public Transform prop_rear_left;

	public Transform prop_rear_right;

	public Transform force_front_left;

	public Transform force_front_right;

	public Transform force_rear_left;

	public Transform force_rear_right;

	public Transform[] Octa_Props;

	public int Octa_Props_number;

	public Transform centre_of_gravity;

	public Vector3 gravity;

	public Transform stability_postion;

	public float Kp_as_pitch;

	public float Ki_as_pitch;

	public float Kd_as_pitch;

	public float error_as_pitch;

	public float error_last_as_pitch;

	public float Kp_as_roll;

	public float Ki_as_roll;

	public float Kd_as_roll;

	public float error_as_roll;

	public float error_last_as_roll;

	public float Kp_as_yaw;

	public float Ki_as_yaw;

	public float Kd_as_yaw;

	public float error_as_yaw;

	public float error_last_as_yaw;

	public float front_left_velocity_average;

	public Quad_Dynamics_independent_propeller()
	{
		this.control_senstivity = 0.01f;
		this.control_senstive_yaw = 0.05f;
		this.max_TA = (float)35;
		this.aero_Drag = 0.3f;
		this.Axis_ = new float[21];
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		this.torque_multiplier = 0.1f;
		this.dynamic_thrust_velocity = (float)27;
		this.auto_stabilize_senstivity = 0.0005f;
		this.auto_stabilize_senst = 0.0005f;
		this.auto_stabilize_senst_set = 0.0005f;
		this.control_senstivity_set = 0.02f;
		this.max_TA_set = (float)35;
		this.roll_pitch_P_set = 0.0005f;
		this.roll_pitch_D_set = 0.0001f;
		this.once = true;
		this.once_2 = true;
		this.on_ground = true;
		this.once_5 = true;
		this.text_display = new string[6];
		this.quads = new Transform[4];
		this.Octa_Props = new Transform[8];
	}

	public override void Start()
	{
		this.in_throttle = (float)0;
		this.control_senstivity = 0.01f;
		this.control_senstive_yaw = 0.05f;
		this.max_TA = (float)35;
		this.torque_multiplier = 0.1f;
		this.gravity = new Vector3((float)0, -9.8f, (float)0);
		this.altitude_hold = false;
		this.auto_stabilize_senstivity = 0.0002f;
		this.auto_stabilize_senst = 0.0002f;
		this.pitch_multiplier = (float)4;
		this.volume_multiplier = (float)2;
		this.coll_front_left = 1;
		this.coll_front_right = 1;
		this.coll_rear_left = 1;
		this.coll_rear_right = 1;
		this.high_speed_collision = 1;
		this.aero_Drag = 0.3f;
		this.once = true;
		this.once_2 = true;
		this.ang_drag = this.rigidbody.angularDrag;
		this.ground_effect_multiplier = (float)1;
		this.GPS_mode = false;
		this.on_ground = true;
		this.once_5 = true;
		this.going_down = false;
		this.level_return_height = (float)25;
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		this.max_TA = PlayerPrefs.GetFloat("Max_Tilt_Angle");
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.control_senstivity = PlayerPrefs.GetFloat("Senstivity_Control");
		this.control_senstive_yaw = PlayerPrefs.GetFloat("Senstivity_Control_Yaw");
		this.auto_stabilize_senst = PlayerPrefs.GetFloat("Auto_Stabilize");
		this.torque_multiplier = PlayerPrefs.GetFloat("Thrust_Multiplier");
		this.dynamic_thrust_velocity = PlayerPrefs.GetFloat("Thrust_Dynamic");
		this.rigidbody.mass = PlayerPrefs.GetFloat("Mass_Multiplier");
		this.quad_selected = PlayerPrefs.GetInt("Quad");
		this.input_mode = PlayerPrefs.GetInt("Input_mode");
		this.enable_controller = PlayerPrefs.GetInt("Controller_Status");
		this.aero_Drag = PlayerPrefs.GetFloat("Aerodynamic_Drag");
		this.flying_mode = PlayerPrefs.GetInt("Flying_Mode");
		this.flying_mode_set = this.flying_mode;
		this.auto_stabilize_senst_set = this.auto_stabilize_senst;
		this.control_senstivity_set = this.control_senstivity;
		this.max_TA_set = this.max_TA;
		if (PlayerPrefs.GetInt("Manual_Mode") == 1)
		{
			this.manual_mode_toggle = true;
		}
		else
		{
			this.manual_mode_toggle = false;
		}
		if (PlayerPrefs.GetInt("Lights_Flip") == 1)
		{
			this.lights_flip_toggle = true;
		}
		else
		{
			this.lights_flip_toggle = false;
		}
		this.roll_pitch_P = PlayerPrefs.GetFloat("Pitch_Roll_P");
		this.roll_pitch_I = PlayerPrefs.GetFloat("Pitch_Roll_I");
		this.roll_pitch_D = PlayerPrefs.GetFloat("Pitch_Roll_D");
		this.roll_pitch_P_set = this.roll_pitch_P;
		this.roll_pitch_D_set = this.roll_pitch_D;
		this.yaw_P = PlayerPrefs.GetFloat("Yaw_P");
		this.yaw_I = PlayerPrefs.GetFloat("Yaw_I");
		this.yaw_D = PlayerPrefs.GetFloat("Yaw_D");
		if (PlayerPrefs.GetInt("Smart_Mode") == 1)
		{
			this.smart_mode = true;
		}
		if (PlayerPrefs.GetInt("Smart_Mode") == 0)
		{
			this.smart_mode = false;
		}
		if (this.flying_mode != 0)
		{
			this.smart_mode = false;
		}
		this.controller_l_h_int = PlayerPrefs.GetInt("Left_Horizontal_Joy");
		this.controller_l_v_int = PlayerPrefs.GetInt("Left_Vertical_Joy");
		this.controller_r_h_int = PlayerPrefs.GetInt("Right_Horizontal_Joy");
		this.controller_r_v_int = PlayerPrefs.GetInt("Right_Vertical_Joy");
		this.controller_l_h_i_int = PlayerPrefs.GetInt("Left_Horizontal_Joy_Inv");
		this.controller_l_v_i_int = PlayerPrefs.GetInt("Left_Vertical_Joy_Inv");
		this.controller_r_h_i_int = PlayerPrefs.GetInt("Right_Horizontal_Joy_Inv");
		this.controller_r_v_i_int = PlayerPrefs.GetInt("Right_Vertical_Joy_Inv");
		this.quads[0].renderer.enabled = false;
		this.quads[1].renderer.enabled = false;
		this.quads[2].renderer.enabled = false;
		this.quads[3].gameObject.SetActive(false);
		if (this.enable_controller != 0)
		{
			Screen.sleepTimeout = -1;
		}
		this.quads[this.quad_selected].renderer.enabled = true;
		for (int i = 0; i < 4; i++)
		{
			if (this.lights_flip_toggle)
			{
				int num = 0;
				Color color = this.quads[i].renderer.materials[4].color;
				float num2 = color.r = (float)num;
				Color color2 = this.quads[i].renderer.materials[4].color = color;
				int num3 = 1;
				Color color3 = this.quads[i].renderer.materials[4].color;
				float num4 = color3.g = (float)num3;
				Color color4 = this.quads[i].renderer.materials[4].color = color3;
				int num5 = 0;
				Color color5 = this.quads[i].renderer.materials[4].color;
				float num6 = color5.b = (float)num5;
				Color color6 = this.quads[i].renderer.materials[4].color = color5;
				int num7 = 1;
				Color color7 = this.quads[i].renderer.materials[3].color;
				float num8 = color7.r = (float)num7;
				Color color8 = this.quads[i].renderer.materials[3].color = color7;
				int num9 = 0;
				Color color9 = this.quads[i].renderer.materials[3].color;
				float num10 = color9.g = (float)num9;
				Color color10 = this.quads[i].renderer.materials[3].color = color9;
				int num11 = 0;
				Color color11 = this.quads[i].renderer.materials[3].color;
				float num12 = color11.b = (float)num11;
				Color color12 = this.quads[i].renderer.materials[3].color = color11;
			}
			else
			{
				int num13 = 1;
				Color color13 = this.quads[i].renderer.materials[4].color;
				float num14 = color13.r = (float)num13;
				Color color14 = this.quads[i].renderer.materials[4].color = color13;
				int num15 = 0;
				Color color15 = this.quads[i].renderer.materials[4].color;
				float num16 = color15.g = (float)num15;
				Color color16 = this.quads[i].renderer.materials[4].color = color15;
				int num17 = 0;
				Color color17 = this.quads[i].renderer.materials[4].color;
				float num18 = color17.b = (float)num17;
				Color color18 = this.quads[i].renderer.materials[4].color = color17;
				int num19 = 0;
				Color color19 = this.quads[i].renderer.materials[3].color;
				float num20 = color19.r = (float)num19;
				Color color20 = this.quads[i].renderer.materials[3].color = color19;
				int num21 = 1;
				Color color21 = this.quads[i].renderer.materials[3].color;
				float num22 = color21.g = (float)num21;
				Color color22 = this.quads[i].renderer.materials[3].color = color21;
				int num23 = 0;
				Color color23 = this.quads[i].renderer.materials[3].color;
				float num24 = color23.b = (float)num23;
				Color color24 = this.quads[i].renderer.materials[3].color = color23;
			}
		}
		this.rigidbody.drag = this.aero_Drag;
		if (this.scene_selected == 0 || this.scene_selected == 3)
		{
			this.max_range = 800;
		}
		else
		{
			this.max_range = 1800;
		}
		this.torque_mult_vfx = (float)1 / (this.torque_multiplier * (float)10);
	}

	public override void FixedUpdate()
	{
		this.rigidbody.drag = this.aero_Drag;
		if (this.enable_controller == 0)
		{
			if (this.input_mode == 0)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 1)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 3)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 4)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
			}
			else
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = Input.acceleration.y + 0.4f;
				this.joy_in_roll = -Input.acceleration.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
		}
		else
		{
			this.Axis_[1] = Input.GetAxis("Horizontal");
			this.Axis_[2] = Input.GetAxis("Vertical");
			this.Axis_[3] = Input.GetAxis("Third_Axis");
			this.Axis_[4] = Input.GetAxis("Fourth_Axis");
			this.Axis_[5] = Input.GetAxis("Fifth_Axis");
			this.Axis_[6] = Input.GetAxis("Sixth_Axis");
			this.Axis_[7] = Input.GetAxis("Seventh_Axis");
			this.Axis_[8] = Input.GetAxis("Eighth_Axis");
			this.Axis_[9] = Input.GetAxis("Ninth_Axis");
			this.Axis_[10] = Input.GetAxis("Tenth_Axis");
			this.Axis_[11] = Input.GetAxis("Eleventh_Axis");
			this.Axis_[12] = Input.GetAxis("Twelveth_Axis");
			this.Axis_[13] = Input.GetAxis("Thirteenth_Axis");
			this.Axis_[14] = Input.GetAxis("Fourteenth_Axis");
			this.Axis_[15] = Input.GetAxis("Fifteenth_Axis");
			this.Axis_[16] = Input.GetAxis("Sixteenth_Axis");
			this.Axis_[17] = Input.GetAxis("Seventeenth_Axis");
			this.Axis_[18] = Input.GetAxis("Eighteenth_Axis");
			this.Axis_[19] = Input.GetAxis("Nineteenth_Axis");
			this.Axis_[20] = Input.GetAxis("Twentyth_Axis");
			if (this.input_mode == 0)
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
			else if (this.input_mode == 1)
			{
				this.joy_in_throttle = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
			else if (this.input_mode == 3)
			{
				this.joy_in_throttle = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
			}
			else if (this.input_mode == 4)
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
			}
			else
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = Input.acceleration.y + 0.4f;
				this.joy_in_roll = -Input.acceleration.x;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
		}
		this.in_pitch = this.joy_in_pitch;
		this.in_roll = this.joy_in_roll;
		this.in_yaw = this.joy_in_yaw;
		if (this.sm_mode > 1 || this.smart_mode)
		{
			this.flying_mode = 0;
		}
		else
		{
			this.flying_mode = this.flying_mode_set;
		}
		this.vertical_velocity = this.rigidbody.velocity.y;
		this.hor_vel = Mathf.Sqrt(this.rigidbody.velocity.x * this.rigidbody.velocity.x + this.rigidbody.velocity.z * this.rigidbody.velocity.z);
		if (this.hor_vel < (float)0)
		{
			this.hor_vel = -this.hor_vel;
		}
		if (this.sm_mode != 4)
		{
			this.return_height = false;
			this.going_down = false;
			this.level_return_height = this.transform.position.y;
		}
		if ((this.on_ground && this.vertical_velocity > 0.01f) || this.joy_in_throttle > 0.01f)
		{
			this.on_ground = false;
			this.going_down = false;
		}
		int layerMask = -2049;
		RaycastHit raycastHit = default(RaycastHit);
		if (Physics.Raycast(this.transform.position, -Vector3.up, out raycastHit, (float)20, layerMask))
		{
			this.distanceToGround = raycastHit.distance;
		}
		if (this.on_ground)
		{
			this.sm_mode = 1;
			this.max_height_reached = this.transform.position.y;
		}
		if (this.smart_mode && !this.on_ground)
		{
			if (this.roll < (float)0)
			{
				this.roll_balance = -this.roll;
			}
			else
			{
				this.roll_balance = this.roll;
			}
			if (this.pitch < (float)0)
			{
				this.pitch_balance = -this.pitch;
			}
			else
			{
				this.pitch_balance = this.pitch;
			}
			float y = this.transform.position.y;
			Vector3 position = this.GPS_pos.position;
			float num = position.y = y;
			Vector3 vector = this.GPS_pos.position = position;
			this.GPS_pos_dist = Vector3.Distance(this.transform.position, this.GPS_pos.position);
			if (Time.time > this.old_time + 0.05f)
			{
				this.GPS_pos_vel_d = Vector3.Distance(this.GPS_pos.position, this.GPS_pos_old.position);
				this.GPS_pos_old.position = this.rigidbody.position;
				this.old_time = Time.time;
			}
			if (this.GPS_mode)
			{
				if (this.joy_in_pitch == (float)0 && this.joy_in_roll == (float)0 && this.sm_mode != 4)
				{
					if (this.once)
					{
						float x = this.transform.position.x;
						Vector3 position2 = this.GPS_pos.position;
						float num2 = position2.x = x;
						Vector3 vector2 = this.GPS_pos.position = position2;
						float z = this.transform.position.z;
						Vector3 position3 = this.GPS_pos.position;
						float num3 = position3.z = z;
						Vector3 vector3 = this.GPS_pos.position = position3;
						this.old_time_2 = Time.time;
						this.once = false;
					}
					if (this.once_2 && (Time.time > this.old_time_2 + (float)4 || this.hor_vel < 0.5f))
					{
						float x2 = this.transform.position.x;
						Vector3 position4 = this.GPS_pos.position;
						float num4 = position4.x = x2;
						Vector3 vector4 = this.GPS_pos.position = position4;
						float z2 = this.transform.position.z;
						Vector3 position5 = this.GPS_pos.position;
						float num5 = position5.z = z2;
						Vector3 vector5 = this.GPS_pos.position = position5;
						this.once_2 = false;
					}
					this.angle_move_cal = (float)180;
					this.GPS_pos_angle = this.GPS_pos.eulerAngles.y;
					this.angle_move = this.yaw + this.angle_move_cal - this.GPS_pos_angle;
					this.pitch_roll_magnitude = this.GPS_pos_dist * 0.1f;
					this.rigidbody.drag = this.aero_Drag * (float)3;
					if (this.pitch_roll_magnitude > 0.8f)
					{
						this.pitch_roll_magnitude = 0.8f;
					}
					if (this.pitch_roll_magnitude < -0.8f)
					{
						this.pitch_roll_magnitude = -0.8f;
					}
					if (this.GPS_pos_vel_d > this.GPS_pos_dist)
					{
						this.pitch_roll_magnitude -= this.hor_vel * 0.1f;
					}
					if (this.GPS_pos_vel_d < this.GPS_pos_dist)
					{
						this.pitch_roll_magnitude += this.hor_vel * 0.1f;
					}
					if (this.pitch_roll_magnitude > 0.8f)
					{
						this.pitch_roll_magnitude = 0.8f;
					}
					if (this.pitch_roll_magnitude < -0.8f)
					{
						this.pitch_roll_magnitude = -0.8f;
					}
					this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
					this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
				}
				else
				{
					if (this.sm_mode == 3)
					{
						this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
						this.return_home_angle = this.home_point.eulerAngles.y;
						this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
						this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
						this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
						this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
					}
					else if (this.sm_mode == 2)
					{
						this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
						this.angle_move = this.yaw + this.angle_move_cal;
						this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
						this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
						this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
					}
					else if (this.sm_mode == 4)
					{
						if (!this.going_down)
						{
							if (this.level_return_height < (float)30)
							{
								this.level_return_height = (float)30;
							}
							this.level_flight = this.level_return_height;
						}
						if (this.transform.position.y > this.level_flight - (float)5 && !this.return_height)
						{
							this.return_height = true;
						}
						if (this.return_height)
						{
							this.angle_move_cal = (float)180;
							this.return_home_angle = this.home_point.eulerAngles.y;
							this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
							float x3 = this.home_point_hor.position.x;
							Vector3 position6 = this.GPS_pos.position;
							float num6 = position6.x = x3;
							Vector3 vector6 = this.GPS_pos.position = position6;
							float z3 = this.home_point_hor.position.z;
							Vector3 position7 = this.GPS_pos.position;
							float num7 = position7.z = z3;
							Vector3 vector7 = this.GPS_pos.position = position7;
							this.home_distance_hor = Vector3.Distance(this.transform.position, this.home_point_hor.position);
							this.pitch_roll_magnitude = this.home_distance_hor * 0.05f;
							this.rigidbody.drag = this.aero_Drag * (float)3;
							if (this.pitch_roll_magnitude > 0.8f)
							{
								this.pitch_roll_magnitude = 0.8f;
							}
							if (this.pitch_roll_magnitude < -0.8f)
							{
								this.pitch_roll_magnitude = -0.8f;
							}
							if (this.home_distance_hor < (float)25)
							{
								if (this.GPS_pos_vel_d > this.home_distance_hor)
								{
									this.pitch_roll_magnitude -= this.hor_vel * 0.2f;
								}
								if (this.GPS_pos_vel_d < this.home_distance_hor)
								{
									this.pitch_roll_magnitude += this.hor_vel * 0.2f;
								}
							}
							if (this.home_distance_hor < (float)100)
							{
								if (this.pitch_roll_magnitude > 0.5f)
								{
									this.pitch_roll_magnitude = 0.5f;
								}
								if (this.pitch_roll_magnitude < -0.5f)
								{
									this.pitch_roll_magnitude = -0.5f;
								}
							}
							if (this.home_distance_hor < (float)4)
							{
								this.going_down = true;
								this.level_flight = this.transform.position.y;
								if (this.transform.position.y - this.home_point.position.y < (float)3)
								{
									this.joy_in_throttle = -0.02f;
								}
								else if (this.transform.position.y - this.home_point.position.y > (float)50)
								{
									this.joy_in_throttle = -0.5f;
								}
								else
								{
									this.joy_in_throttle = -0.1f;
								}
							}
							this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
							this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
						}
					}
					else
					{
						this.in_pitch = this.joy_in_pitch;
						this.in_roll = this.joy_in_roll;
					}
					this.once = true;
					this.once_2 = true;
				}
			}
			else if (this.sm_mode == 3)
			{
				this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
				this.return_home_angle = this.home_point.eulerAngles.y;
				this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
				this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
				this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
				this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
			}
			else if (this.sm_mode == 2)
			{
				this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
				this.angle_move = this.yaw + this.angle_move_cal;
				this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
				this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
				this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
			}
			else if (this.sm_mode == 4)
			{
				if (!this.going_down)
				{
					if (this.level_return_height < (float)30)
					{
						this.level_return_height = (float)30;
					}
					this.level_flight = this.level_return_height;
				}
				if (this.transform.position.y > this.level_flight - (float)5 && !this.return_height)
				{
					this.return_height = true;
				}
				if (this.return_height)
				{
					this.angle_move_cal = (float)180;
					this.return_home_angle = this.home_point.eulerAngles.y;
					this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
					float x4 = this.home_point_hor.position.x;
					Vector3 position8 = this.GPS_pos.position;
					float num8 = position8.x = x4;
					Vector3 vector8 = this.GPS_pos.position = position8;
					float z4 = this.home_point_hor.position.z;
					Vector3 position9 = this.GPS_pos.position;
					float num9 = position9.z = z4;
					Vector3 vector9 = this.GPS_pos.position = position9;
					this.home_distance_hor = Vector3.Distance(this.transform.position, this.home_point_hor.position);
					this.pitch_roll_magnitude = this.home_distance_hor * 0.05f;
					this.rigidbody.drag = this.aero_Drag * (float)3;
					if (this.pitch_roll_magnitude > 0.8f)
					{
						this.pitch_roll_magnitude = 0.8f;
					}
					if (this.pitch_roll_magnitude < -0.8f)
					{
						this.pitch_roll_magnitude = -0.8f;
					}
					if (this.home_distance_hor < (float)25)
					{
						if (this.GPS_pos_vel_d > this.home_distance_hor)
						{
							this.pitch_roll_magnitude -= this.hor_vel * 0.2f;
						}
						if (this.GPS_pos_vel_d < this.home_distance_hor)
						{
							this.pitch_roll_magnitude += this.hor_vel * 0.2f;
						}
					}
					if (this.home_distance_hor < (float)100)
					{
						if (this.pitch_roll_magnitude > 0.5f)
						{
							this.pitch_roll_magnitude = 0.5f;
						}
						if (this.pitch_roll_magnitude < -0.5f)
						{
							this.pitch_roll_magnitude = -0.5f;
						}
					}
					if (this.home_distance_hor < (float)4)
					{
						this.going_down = true;
						this.level_flight = this.transform.position.y;
						if (this.transform.position.y - this.home_point.position.y < (float)3)
						{
							this.joy_in_throttle = -0.02f;
						}
						else if (this.transform.position.y - this.home_point.position.y > (float)50)
						{
							this.joy_in_throttle = -0.5f;
						}
						else
						{
							this.joy_in_throttle = -0.1f;
						}
					}
					this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
					this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
				}
			}
			else
			{
				this.in_pitch = this.joy_in_pitch;
				this.in_roll = this.joy_in_roll;
			}
			if (this.distanceToGround < 0.1f && this.vertical_velocity > -0.05f && this.vertical_velocity < 0.05f && !this.on_ground)
			{
				if (this.once_5)
				{
					this.Ground_wait_time = Time.time;
					this.once_5 = false;
				}
				if (Time.time > this.Ground_wait_time + (float)1)
				{
					this.on_ground = true;
				}
			}
			else
			{
				this.once_5 = true;
			}
			if (this.joy_in_throttle < 0.005f && this.joy_in_throttle > -0.005f)
			{
				if (this.countii == 0)
				{
					this.level_flight = this.transform.position.y;
					this.countii = 1;
				}
				if (this.counti == 0 && this.vertical_velocity < 0.2f && this.vertical_velocity > -0.2f)
				{
					this.level_flight = this.transform.position.y;
					this.counti = 1;
				}
				this.vertical_hold = this.level_flight - this.transform.position.y;
			}
			else
			{
				this.vertical_hold = (float)0;
				this.counti = 0;
				this.countii = 0;
			}
			this.in_throttle = 9.8f * this.rigidbody.mass * 0.25f / this.torque_multiplier + this.vertical_hold * 0.6f - this.vertical_velocity * 0.1f + this.joy_in_throttle * (float)2;
			this.in_pitch *= Mathf.Clamp((this.dynamic_thrust_velocity - this.hor_vel) / this.dynamic_thrust_velocity, (float)0, (float)1);
			this.in_roll *= Mathf.Clamp((this.dynamic_thrust_velocity - this.hor_vel) / this.dynamic_thrust_velocity, (float)0, (float)1);
			if (this.max_TA > (float)40)
			{
				this.max_TA = (float)40;
			}
			if (this.in_throttle > (float)2)
			{
				this.in_throttle = (float)2;
			}
			if (this.in_throttle < 0.1f && this.flying_mode != 3)
			{
				this.in_throttle = 0.1f;
			}
		}
		else
		{
			if (this.altitude_hold)
			{
				this.max_TA = (float)35;
				this.auto_stabilize_senst = 0.0005f;
				this.control_senstivity = 0.02f;
				this.roll_pitch_P = 0.0005f;
				this.roll_pitch_D = 0.0002f;
				this.in_throttle = 9.8f * this.rigidbody.mass * 0.25f / this.torque_multiplier + (this.level_flight - this.transform.position.y) * (float)2 - this.rigidbody.velocity.y;
				if (this.in_throttle > (float)2)
				{
					this.in_throttle = (float)2;
				}
				if (this.in_throttle < (float)0)
				{
					this.in_throttle = (float)0;
				}
				this.joy_in_pitch *= Mathf.Clamp(-(this.in_throttle - (float)2), (float)0, (float)1);
				this.joy_in_roll *= Mathf.Clamp(-(this.in_throttle - (float)2), (float)0, (float)1);
			}
			else
			{
				this.auto_stabilize_senst = this.auto_stabilize_senst_set;
				this.roll_pitch_P = this.roll_pitch_P_set;
				this.control_senstivity = this.control_senstivity_set;
				this.max_TA = this.max_TA_set;
				this.in_throttle = this.joy_in_throttle + (float)1;
				this.roll_pitch_D = this.roll_pitch_D_set;
				if (this.on_ground && this.joy_in_throttle == (float)0)
				{
					this.in_throttle -= 0.5f;
				}
			}
			this.in_pitch = this.joy_in_pitch;
			this.in_roll = this.joy_in_roll;
			this.in_yaw = this.joy_in_yaw;
			this.auto_stabilize_senstivity = this.auto_stabilize_senst;
		}
		if (this.transform.rotation.eulerAngles.x >= (float)180)
		{
			this.pitch = this.transform.rotation.eulerAngles.x - (float)360;
		}
		else
		{
			this.pitch = this.transform.rotation.eulerAngles.x;
		}
		if (this.transform.rotation.eulerAngles.z >= (float)180)
		{
			this.roll = this.transform.rotation.eulerAngles.z - (float)360;
		}
		else
		{
			this.roll = this.transform.rotation.eulerAngles.z;
		}
		this.yaw = this.transform.eulerAngles.y;
		if (this.flying_mode != 0)
		{
			this.Stabilize_pitch = this.auto_stabilize_senstivity;
			this.Stabilize_roll = this.auto_stabilize_senstivity;
		}
		else
		{
			this.Stabilize_pitch = this.roll_pitch_P;
			this.Stabilize_roll = this.roll_pitch_P;
		}
		this.control_senstive_yaw = this.yaw_P;
		float num10 = 0f;
		float num11 = 0f;
		num10 = this.roll - this.in_roll * this.max_TA;
		num11 = this.pitch - this.in_pitch * this.max_TA;
		this.error_as_pitch = this.pitch;
		this.Kd_as_pitch = (this.error_as_pitch - this.error_last_as_pitch) / Time.deltaTime;
		this.error_as_roll = this.roll;
		this.Kd_as_roll = (this.error_as_roll - this.error_last_as_roll) / Time.deltaTime;
		this.Ki_as_roll += num10 * Time.deltaTime;
		this.Ki_as_pitch += num11 * Time.deltaTime;
		this.error_as_yaw = this.yaw;
		this.Kd_as_yaw = (this.error_as_yaw - this.error_last_as_yaw) / Time.deltaTime;
		Vector3 vector10 = this.transform.InverseTransformDirection(this.rigidbody.angularVelocity);
		this.Kd_as_roll = vector10.z * (float)75;
		this.Kd_as_pitch = vector10.x * (float)75;
		if (this.flying_mode == 1)
		{
			this.rigidbody.angularDrag = 0.1f;
			this.motor_torque_front_left = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_front_right = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_left = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_right = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
		}
		else if (this.flying_mode == 2)
		{
			this.Stabilize_pitch = (float)0;
			this.Stabilize_roll = (float)0;
			this.rigidbody.angularDrag = 0.1f;
			this.motor_torque_front_left = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_front_right = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_left = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_right = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
		}
		else if (this.flying_mode == 3)
		{
			this.Stabilize_pitch = (float)0;
			this.Stabilize_roll = (float)0;
			this.rigidbody.angularDrag = 0.1f;
			this.in_throttle = (this.in_throttle - (float)1) * (float)2;
			this.motor_torque_front_left = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_front_right = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_left = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_right = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
		}
		else
		{
			this.rigidbody.angularDrag = 0.1f;
			this.motor_torque_front_left = this.in_throttle * this.torque_multiplier + num11 * this.Stabilize_pitch + num10 * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_front_right = this.in_throttle * this.torque_multiplier + num11 * this.Stabilize_pitch - num10 * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw + this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D + this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_left = this.in_throttle * this.torque_multiplier - num11 * this.Stabilize_pitch + num10 * this.Stabilize_roll - this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D + this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I + this.Ki_as_roll * this.roll_pitch_I;
			this.motor_torque_rear_right = this.in_throttle * this.torque_multiplier - num11 * this.Stabilize_pitch - num10 * this.Stabilize_roll + this.in_yaw * this.control_senstive_yaw - this.Kd_as_pitch * this.roll_pitch_D - this.Kd_as_roll * this.roll_pitch_D - this.Ki_as_pitch * this.roll_pitch_I - this.Ki_as_roll * this.roll_pitch_I;
		}
		if (this.flying_mode == 3)
		{
			this.motor_torque_front_left = Mathf.Clamp(this.motor_torque_front_left, -2.5f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_front_right = Mathf.Clamp(this.motor_torque_front_right, -2.5f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_rear_left = Mathf.Clamp(this.motor_torque_rear_left, -2.5f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_rear_right = Mathf.Clamp(this.motor_torque_rear_right, -2.5f * this.torque_multiplier, 2.5f * this.torque_multiplier);
		}
		else
		{
			this.motor_torque_front_left = Mathf.Clamp(this.motor_torque_front_left, 0.1f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_front_right = Mathf.Clamp(this.motor_torque_front_right, 0.1f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_rear_left = Mathf.Clamp(this.motor_torque_rear_left, 0.1f * this.torque_multiplier, 2.5f * this.torque_multiplier);
			this.motor_torque_rear_right = Mathf.Clamp(this.motor_torque_rear_right, 0.1f * this.torque_multiplier, 2.5f * this.torque_multiplier);
		}
		Vector3 vector11 = this.transform.InverseTransformDirection(this.rigidbody.GetPointVelocity(this.prop_front_left.position));
		Vector3 vector12 = this.transform.InverseTransformDirection(this.rigidbody.GetPointVelocity(this.prop_front_right.position));
		Vector3 vector13 = this.transform.InverseTransformDirection(this.rigidbody.GetPointVelocity(this.prop_rear_left.position));
		Vector3 vector14 = this.transform.InverseTransformDirection(this.rigidbody.GetPointVelocity(this.prop_rear_right.position));
		float num12 = (float)0;
		float num13 = (float)0;
		float num14 = (float)0;
		float num15 = (float)0;
		num12 = Mathf.Clamp(vector11.y, -this.dynamic_thrust_velocity, this.dynamic_thrust_velocity);
		num13 = Mathf.Clamp(vector12.y, -this.dynamic_thrust_velocity, this.dynamic_thrust_velocity);
		num14 = Mathf.Clamp(vector13.y, -this.dynamic_thrust_velocity, this.dynamic_thrust_velocity);
		num15 = Mathf.Clamp(vector14.y, -this.dynamic_thrust_velocity, this.dynamic_thrust_velocity);
		this.front_left_velocity_average = (vector11.y + vector12.y + vector13.y + vector14.y) / 4f;
		float num16 = this.torque_multiplier * (float)2 * (num12 / this.dynamic_thrust_velocity);
		float num17 = this.torque_multiplier * (float)2 * (num13 / this.dynamic_thrust_velocity);
		float num18 = this.torque_multiplier * (float)2 * (num14 / this.dynamic_thrust_velocity);
		float num19 = this.torque_multiplier * (float)2 * (num15 / this.dynamic_thrust_velocity);
		float num20 = this.motor_torque_front_left - num16;
		float num21 = this.motor_torque_front_right - num17;
		float num22 = this.motor_torque_rear_left - num18;
		float num23 = this.motor_torque_rear_right - num19;
		if (this.motor_torque_front_left >= (float)0)
		{
			num20 = Mathf.Clamp(num20, (float)0, this.motor_torque_front_left);
		}
		else if (this.motor_torque_front_left < (float)0)
		{
			num20 = Mathf.Clamp(num20, this.motor_torque_front_left, (float)0);
		}
		if (this.motor_torque_front_right >= (float)0)
		{
			num21 = Mathf.Clamp(num21, (float)0, this.motor_torque_front_right);
		}
		else if (this.motor_torque_front_right < (float)0)
		{
			num21 = Mathf.Clamp(num21, this.motor_torque_front_right, (float)0);
		}
		if (this.motor_torque_rear_left >= (float)0)
		{
			num22 = Mathf.Clamp(num22, (float)0, this.motor_torque_rear_left);
		}
		else if (this.motor_torque_rear_left < (float)0)
		{
			num22 = Mathf.Clamp(num22, this.motor_torque_rear_left, (float)0);
		}
		if (this.motor_torque_rear_right >= (float)0)
		{
			num23 = Mathf.Clamp(num23, (float)0, this.motor_torque_rear_right);
		}
		else if (this.motor_torque_rear_right < (float)0)
		{
			num23 = Mathf.Clamp(num23, this.motor_torque_rear_right, (float)0);
		}
		if (this.flying_mode != 0)
		{
			this.rigidbody.AddRelativeTorque((float)0, (this.in_yaw * this.control_senstive_yaw - vector10.y * this.yaw_D) * (float)this.high_speed_collision, (float)0);
		}
		else
		{
			this.rigidbody.AddTorque((float)0, (this.in_yaw * this.yaw_P - this.rigidbody.angularVelocity.y * this.yaw_D) * (float)this.high_speed_collision, (float)0);
		}
		this.error_last_as_pitch = this.error_as_pitch;
		this.error_last_as_roll = this.error_as_roll;
		this.error_last_as_yaw = this.error_as_yaw;
		this.rigidbody.AddForceAtPosition(this.transform.up * num20 * (float)this.coll_front_left * (float)this.high_speed_collision, this.prop_front_left.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * num21 * (float)this.coll_front_right * (float)this.high_speed_collision, this.prop_front_right.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * num22 * (float)this.coll_rear_left * (float)this.high_speed_collision, this.prop_rear_left.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * num23 * (float)this.coll_rear_right * (float)this.high_speed_collision, this.prop_rear_right.position);
		this.particle_effects.particleSystem.emissionRate = (float)0;
		this.ground_effect_multiplier = (float)0;
		this.particle_effects.gameObject.SetActive(false);
	}

	public override void LateUpdate()
	{
		if (this.rigidbody.position.y > this.max_height_reached)
		{
			this.max_height_reached = this.rigidbody.position.y;
		}
		this.coll_front_left = ((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll;
		this.coll_front_right = ((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll;
		this.coll_rear_left = ((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll;
		this.coll_rear_right = ((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll;
		if (this.motor_torque_front_left > 0.15f && this.coll_front_left == 0)
		{
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[0] = "Prop Front Left Broken \n";
			this.text_print();
		}
		if (this.motor_torque_front_right > 0.15f && this.coll_front_right == 0)
		{
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[1] = "Prop Front Right Broken \n";
			this.text_print();
		}
		if (this.motor_torque_rear_left > 0.15f && this.coll_rear_left == 0)
		{
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[2] = "Prop Rear Left Broken \n";
			this.text_print();
		}
		if (this.motor_torque_rear_right > 0.15f && this.coll_rear_right == 0)
		{
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[3] = "Prop Rear Right Broken \n";
			this.text_print();
		}
		this.prop_front_left.Rotate((float)0, (float)0, this.motor_torque_front_left * (float)this.coll_front_left * (float)this.high_speed_collision * (float)-3000 * this.torque_mult_vfx);
		this.prop_front_right.Rotate((float)0, (float)0, this.motor_torque_front_right * (float)this.coll_front_right * (float)this.high_speed_collision * (float)3000 * this.torque_mult_vfx);
		this.prop_rear_left.Rotate((float)0, (float)0, this.motor_torque_rear_left * (float)this.coll_rear_left * (float)this.high_speed_collision * (float)3000 * this.torque_mult_vfx);
		this.prop_rear_right.Rotate((float)0, (float)0, this.motor_torque_rear_right * (float)this.coll_rear_right * (float)this.high_speed_collision * (float)-3000 * this.torque_mult_vfx);
		if (this.motor_torque_front_left < (float)0)
		{
			this.motor_torque_front_left = -this.motor_torque_front_left;
		}
		if (this.motor_torque_front_right < (float)0)
		{
			this.motor_torque_front_right = -this.motor_torque_front_right;
		}
		if (this.motor_torque_rear_left < (float)0)
		{
			this.motor_torque_rear_left = -this.motor_torque_rear_left;
		}
		if (this.motor_torque_rear_right < (float)0)
		{
			this.motor_torque_rear_right = -this.motor_torque_rear_right;
		}
		float a = this.motor_torque_front_left * (float)this.coll_front_left * (float)15 * this.torque_mult_vfx;
		Color color = this.prop_front_left.renderer.materials[0].color;
		float num = color.a = a;
		Color color2 = this.prop_front_left.renderer.materials[0].color = color;
		float a2 = this.motor_torque_front_right * (float)this.coll_front_right * (float)15 * this.torque_mult_vfx;
		Color color3 = this.prop_front_right.renderer.materials[0].color;
		float num2 = color3.a = a2;
		Color color4 = this.prop_front_right.renderer.materials[0].color = color3;
		float a3 = this.motor_torque_rear_left * (float)this.coll_rear_left * (float)15 * this.torque_mult_vfx;
		Color color5 = this.prop_rear_left.renderer.materials[0].color;
		float num3 = color5.a = a3;
		Color color6 = this.prop_rear_left.renderer.materials[0].color = color5;
		float a4 = this.motor_torque_rear_right * (float)this.coll_rear_right * (float)15 * this.torque_mult_vfx;
		Color color7 = this.prop_rear_right.renderer.materials[0].color;
		float num4 = color7.a = a4;
		Color color8 = this.prop_rear_right.renderer.materials[0].color = color7;
		float a5 = (float)1 - this.motor_torque_front_left * (float)this.coll_front_left * (float)15 * this.torque_mult_vfx;
		Color color9 = this.prop_front_left.renderer.materials[1].color;
		float num5 = color9.a = a5;
		Color color10 = this.prop_front_left.renderer.materials[1].color = color9;
		float a6 = (float)1 - this.motor_torque_front_right * (float)this.coll_front_right * (float)15 * this.torque_mult_vfx;
		Color color11 = this.prop_front_right.renderer.materials[1].color;
		float num6 = color11.a = a6;
		Color color12 = this.prop_front_right.renderer.materials[1].color = color11;
		float a7 = (float)1 - this.motor_torque_rear_left * (float)this.coll_rear_left * (float)15 * this.torque_mult_vfx;
		Color color13 = this.prop_rear_left.renderer.materials[1].color;
		float num7 = color13.a = a7;
		Color color14 = this.prop_rear_left.renderer.materials[1].color = color13;
		float a8 = (float)1 - this.motor_torque_rear_right * (float)this.coll_rear_right * (float)15 * this.torque_mult_vfx;
		Color color15 = this.prop_rear_right.renderer.materials[1].color;
		float num8 = color15.a = a8;
		Color color16 = this.prop_rear_right.renderer.materials[1].color = color15;
		if (this.coll_front_left == 0)
		{
			this.prop_front_left.audio.pitch = (float)2;
		}
		else
		{
			this.prop_front_left.audio.pitch = Mathf.Clamp(this.motor_torque_front_left * this.pitch_multiplier * this.torque_mult_vfx, 0.2f, (float)2);
		}
		if (this.coll_front_right == 0)
		{
			this.prop_front_right.audio.pitch = (float)2;
		}
		else
		{
			this.prop_front_right.audio.pitch = Mathf.Clamp(this.motor_torque_front_right * this.pitch_multiplier * this.torque_mult_vfx, 0.2f, (float)2);
		}
		if (this.coll_rear_left == 0)
		{
			this.prop_rear_left.audio.pitch = (float)2;
		}
		else
		{
			this.prop_rear_left.audio.pitch = Mathf.Clamp(this.motor_torque_rear_left * this.pitch_multiplier * this.torque_mult_vfx, 0.2f, (float)2);
		}
		if (this.coll_rear_right == 0)
		{
			this.prop_rear_right.audio.pitch = (float)2;
		}
		else
		{
			this.prop_rear_right.audio.pitch = Mathf.Clamp(this.motor_torque_rear_right * this.pitch_multiplier * this.torque_mult_vfx, 0.2f, (float)2);
		}
		if (this.coll_front_left == 0)
		{
			this.prop_front_left.audio.volume = 0.1f;
		}
		else
		{
			this.prop_front_left.audio.volume = Mathf.Clamp(this.motor_torque_front_left * this.volume_multiplier * this.torque_mult_vfx, (float)0, 0.9f);
		}
		if (this.coll_front_right == 0)
		{
			this.prop_front_right.audio.volume = 0.1f;
		}
		else
		{
			this.prop_front_right.audio.volume = Mathf.Clamp(this.motor_torque_front_right * this.volume_multiplier * this.torque_mult_vfx, (float)0, 0.9f);
		}
		if (this.coll_rear_left == 0)
		{
			this.prop_rear_left.audio.volume = 0.1f;
		}
		else
		{
			this.prop_rear_left.audio.volume = Mathf.Clamp(this.motor_torque_rear_left * this.volume_multiplier * this.torque_mult_vfx, (float)0, 0.9f);
		}
		if (this.coll_rear_right == 0)
		{
			this.prop_rear_right.audio.volume = 0.1f;
		}
		else
		{
			this.prop_rear_right.audio.volume = Mathf.Clamp(this.motor_torque_rear_right * this.volume_multiplier * this.torque_mult_vfx, (float)0, 0.9f);
		}
		float num9 = Vector3.Distance(this.transform.position, this.controller_location.position);
		if (this.sm_mode == 4)
		{
			this.text_display[4] = "Returning Back to Launch\n";
			this.text_print();
		}
		if (num9 > (float)this.max_range)
		{
			this.sm_mode = 4;
		}
		if (this.sm_mode != 4)
		{
			if (num9 > (float)(this.max_range - 150))
			{
				this.text_display[4] = "Nearing Max. Range, Return Back\n";
				this.text_print();
			}
			if (num9 < (float)(this.max_range - 150))
			{
				this.text_display[4] = "\n";
				this.text_print();
			}
		}
		if (this.scene_selected == 0 && this.rigidbody.position.y < -7.75f)
		{
			this.text_display[5] = "Splash.....\n";
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
		if (this.scene_selected == 1 && this.rigidbody.position.y < -7.45f)
		{
			this.text_display[5] = "Splash.....\n";
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
		if (this.scene_selected == 2 && this.rigidbody.position.y < -1f)
		{
			this.text_display[5] = "Splash.....\n";
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
	}

	public override void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.magnitude > (float)15)
		{
			this.text_display[5] = "High Speed CRASH.....\n";
			this.text_print();
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
	}

	public override void text_print()
	{
		this.warning_display.guiText.fontSize = Screen.height / 30;
		this.warning_display.guiText.text = this.text_display[0] + this.text_display[1] + this.text_display[2] + this.text_display[3] + this.text_display[4] + this.text_display[5];
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Quad_Dynamics_independent_propeller_Backup : MonoBehaviour
{
	public float in_throttle;

	public float in_pitch;

	public float in_roll;

	public float in_yaw;

	public float control_senstivity;

	public float control_senstive_yaw;

	public Transform joystick_left;

	public Transform joystick_right;

	public Transform particle_effects;

	public float joy_in_throttle;

	private float joy_in_pitch;

	private float joy_in_roll;

	private float joy_in_yaw;

	private float ang_drag;

	private float aero_Drag;

	public float Left_Hor_Joy;

	public float Left_Ver_Joy;

	public float Right_Hor_Joy;

	public float Right_Ver_Joy;

	private float pitch_balance;

	private float roll_balance;

	private string[] controller;

	private int controller_int;

	private float[] Axis_;

	private int enable_controller;

	private int controller_l_h_int;

	private int controller_l_v_int;

	private int controller_r_h_int;

	private int controller_r_v_int;

	private int controller_l_h_i_int;

	private int controller_l_v_i_int;

	private int controller_r_h_i_int;

	private int controller_r_v_i_int;

	public float pitch;

	public float roll;

	public float yaw;

	public float angle_move;

	public float angle_move_cal;

	public float return_home_angle;

	public float torque_multiplier;

	public float motor_torque_front_left;

	public float motor_torque_front_right;

	public float motor_torque_rear_left;

	public float motor_torque_rear_right;

	public bool altitude_hold;

	public float vertical_hold;

	public float level_flight;

	public float vertical_velocity;

	public float auto_stabilize_senstivity;

	public float auto_stabilize_senst;

	public float Stabilize_roll;

	public float Stabilize_pitch;

	public float pitch_multiplier;

	public float volume_multiplier;

	public Transform home_point;

	public Transform home_point_hor;

	public float home_distance_hor;

	public float max_height_reached;

	public float GPS_pos_angle;

	public Transform GPS_pos;

	public float GPS_pos_dist;

	public float GPS_pos_vel_d;

	public Transform GPS_pos_old;

	public float old_time;

	public bool once;

	public bool once_2;

	public float pitch_roll_magnitude;

	public bool GPS_mode;

	public bool on_ground;

	public int coll_front_left;

	public int coll_front_right;

	public int coll_rear_left;

	public int coll_rear_right;

	public int high_speed_collision;

	public Transform controller_location;

	public int max_range;

	public Transform warning_display;

	public Transform cam_human;

	public Transform mountains;

	public float distanceToGround;

	public float ground_effect_multiplier;

	public Transform Ground_effects;

	private string[] text_display;

	private float torque_mult_vfx;

	public Transform[] quads;

	private int quad_selected;

	private int input_mode;

	private int scene_selected;

	public Transform home_loc_point;

	public bool smart_mode;

	public int sm_mode;

	public int counti;

	public int countii;

	public Transform prop_front_left;

	public Transform prop_front_right;

	public Transform prop_rear_left;

	public Transform prop_rear_right;

	public Transform centre_of_gravity;

	public Vector3 gravity;

	public Transform stability_postion;

	public Quad_Dynamics_independent_propeller_Backup()
	{
		this.control_senstivity = 0.01f;
		this.control_senstive_yaw = 0.05f;
		this.aero_Drag = 0.3f;
		this.Axis_ = new float[11];
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		this.torque_multiplier = 0.1f;
		this.auto_stabilize_senstivity = 0.0002f;
		this.auto_stabilize_senst = 0.0002f;
		this.once = true;
		this.once_2 = true;
		this.GPS_mode = true;
		this.on_ground = true;
		this.text_display = new string[6];
		this.quads = new Transform[3];
	}

	public override void Start()
	{
		this.in_throttle = (float)0;
		this.control_senstivity = 0.01f;
		this.control_senstive_yaw = 0.05f;
		this.torque_multiplier = 0.1f;
		this.gravity = new Vector3((float)0, -9.8f, (float)0);
		this.altitude_hold = false;
		this.auto_stabilize_senstivity = 0.0002f;
		this.auto_stabilize_senst = 0.0002f;
		this.pitch_multiplier = (float)12;
		this.volume_multiplier = (float)2;
		this.coll_front_left = 1;
		this.coll_front_right = 1;
		this.coll_rear_left = 1;
		this.coll_rear_right = 1;
		this.high_speed_collision = 1;
		this.aero_Drag = 0.3f;
		this.once = true;
		this.once_2 = true;
		this.ang_drag = this.rigidbody.angularDrag;
		this.ground_effect_multiplier = (float)1;
		this.GPS_mode = true;
		this.on_ground = true;
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		if (!PlayerPrefs.HasKey("Senstivity_Control"))
		{
			PlayerPrefs.SetFloat("Senstivity_Control", 0.01f);
		}
		if (!PlayerPrefs.HasKey("Senstivity_Control_Yaw"))
		{
			PlayerPrefs.SetFloat("Senstivity_Control_Yaw", 0.03f);
		}
		if (!PlayerPrefs.HasKey("Auto_Stabilize"))
		{
			PlayerPrefs.SetFloat("Auto_Stabilize", 0.0002f);
		}
		if (!PlayerPrefs.HasKey("Thrust_Multiplier"))
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier", 0.1f);
		}
		if (!PlayerPrefs.HasKey("Mass_Multiplier"))
		{
			PlayerPrefs.SetFloat("Mass_Multiplier", 0.04f);
		}
		if (!PlayerPrefs.HasKey("Units"))
		{
			PlayerPrefs.SetString("Units", "Imperial");
		}
		if (!PlayerPrefs.HasKey("Quad"))
		{
			PlayerPrefs.SetInt("Quad", 0);
		}
		if (!PlayerPrefs.HasKey("Scene"))
		{
			PlayerPrefs.SetInt("Scene", 0);
		}
		if (!PlayerPrefs.HasKey("Input_mode"))
		{
			PlayerPrefs.SetInt("Input_mode", 0);
		}
		if (!PlayerPrefs.HasKey("Thrust_Multiplier_Q0"))
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", 0.1f);
		}
		if (!PlayerPrefs.HasKey("Mass_Multiplier_Q0"))
		{
			PlayerPrefs.SetFloat("Mass_Multiplier_Q0", 0.04f);
		}
		if (!PlayerPrefs.HasKey("Thrust_Multiplier_Q1"))
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", 0.09f);
		}
		if (!PlayerPrefs.HasKey("Mass_Multiplier_Q1"))
		{
			PlayerPrefs.SetFloat("Mass_Multiplier_Q1", 0.05f);
		}
		if (!PlayerPrefs.HasKey("Thrust_Multiplier_Q2"))
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", 0.14f);
		}
		if (!PlayerPrefs.HasKey("Mass_Multiplier_Q2"))
		{
			PlayerPrefs.SetFloat("Mass_Multiplier_Q2", 0.08f);
		}
		if (!PlayerPrefs.HasKey("Quad_Purchased_Q0"))
		{
			PlayerPrefs.SetInt("Quad_Purchased_Q0", 1);
		}
		if (!PlayerPrefs.HasKey("Quad_Purchased_Q1"))
		{
			PlayerPrefs.SetInt("Quad_Purchased_Q1", 0);
		}
		if (!PlayerPrefs.HasKey("Quad_Purchased_Q2"))
		{
			PlayerPrefs.SetInt("Quad_Purchased_Q2", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Purchased_S0"))
		{
			PlayerPrefs.SetInt("Scene_Purchased_S0", 1);
		}
		if (!PlayerPrefs.HasKey("Scene_Purchased_S1"))
		{
			PlayerPrefs.SetInt("Scene_Purchased_S1", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Purchased_S2"))
		{
			PlayerPrefs.SetInt("Scene_Purchased_S2", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_S0"))
		{
			PlayerPrefs.SetInt("Scene_Try_S0", 1);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_S1"))
		{
			PlayerPrefs.SetInt("Scene_Try_S1", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_S2"))
		{
			PlayerPrefs.SetInt("Scene_Try_S2", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_Time_S0"))
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S0", 120);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_Time_S1"))
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S1", 0);
		}
		if (!PlayerPrefs.HasKey("Scene_Try_Time_S2"))
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S2", 0);
		}
		if (!PlayerPrefs.HasKey("Aerodynamic_Drag"))
		{
			PlayerPrefs.SetFloat("Aerodynamic_Drag", 0.3f);
		}
		if (!PlayerPrefs.HasKey("Challenge_selected"))
		{
			PlayerPrefs.SetInt("Challenge_selected", 0);
		}
		if (!PlayerPrefs.HasKey("Challenge_1_Best_time"))
		{
			PlayerPrefs.SetFloat("Challenge_1_Best_time", (float)0);
		}
		if (!PlayerPrefs.HasKey("Challenge_2_Best_time"))
		{
			PlayerPrefs.SetFloat("Challenge_2_Best_time", (float)0);
		}
		if (!PlayerPrefs.HasKey("Challenge_3_Best_time"))
		{
			PlayerPrefs.SetFloat("Challenge_3_Best_time", (float)0);
		}
		if (!PlayerPrefs.HasKey("Challenge_4_Best_time"))
		{
			PlayerPrefs.SetFloat("Challenge_4_Best_time", (float)0);
		}
		if (!PlayerPrefs.HasKey("Challenge_5_Best_time"))
		{
			PlayerPrefs.SetFloat("Challenge_5_Best_time", (float)0);
		}
		if (!PlayerPrefs.HasKey("Challenge_Button"))
		{
			PlayerPrefs.SetString("Challenge_Button", "On");
		}
		if (!PlayerPrefs.HasKey("Attitude_Indicator"))
		{
			PlayerPrefs.SetString("Attitude_Indicator", "On");
		}
		if (!PlayerPrefs.HasKey("Controller_Status"))
		{
			PlayerPrefs.SetInt("Controller_Status", 0);
		}
		if (!PlayerPrefs.HasKey("Left_Horizontal_Joy"))
		{
			PlayerPrefs.SetInt("Left_Horizontal_Joy", 1);
		}
		if (!PlayerPrefs.HasKey("Left_Vertical_Joy"))
		{
			PlayerPrefs.SetInt("Left_Vertical_Joy", 2);
		}
		if (!PlayerPrefs.HasKey("Right_Horizontal_Joy"))
		{
			PlayerPrefs.SetInt("Right_Horizontal_Joy", 3);
		}
		if (!PlayerPrefs.HasKey("Right_Vertical_Joy"))
		{
			PlayerPrefs.SetInt("Right_Vertical_Joy", 4);
		}
		if (!PlayerPrefs.HasKey("Left_Horizontal_Joy_Inv"))
		{
			PlayerPrefs.SetInt("Left_Horizontal_Joy_Inv", 1);
		}
		if (!PlayerPrefs.HasKey("Left_Vertical_Joy_Inv"))
		{
			PlayerPrefs.SetInt("Left_Vertical_Joy_Inv", 1);
		}
		if (!PlayerPrefs.HasKey("Right_Horizontal_Joy_Inv"))
		{
			PlayerPrefs.SetInt("Right_Horizontal_Joy_Inv", 1);
		}
		if (!PlayerPrefs.HasKey("Right_Vertical_Joy_Inv"))
		{
			PlayerPrefs.SetInt("Right_Vertical_Joy_Inv", -1);
		}
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.control_senstivity = PlayerPrefs.GetFloat("Senstivity_Control");
		this.control_senstive_yaw = PlayerPrefs.GetFloat("Senstivity_Control_Yaw");
		this.auto_stabilize_senst = PlayerPrefs.GetFloat("Auto_Stabilize");
		this.torque_multiplier = PlayerPrefs.GetFloat("Thrust_Multiplier");
		this.rigidbody.mass = PlayerPrefs.GetFloat("Mass_Multiplier");
		this.quad_selected = PlayerPrefs.GetInt("Quad");
		this.input_mode = PlayerPrefs.GetInt("Input_mode");
		this.enable_controller = PlayerPrefs.GetInt("Controller_Status");
		this.aero_Drag = PlayerPrefs.GetFloat("Aerodynamic_Drag");
		this.controller_l_h_int = PlayerPrefs.GetInt("Left_Horizontal_Joy");
		this.controller_l_v_int = PlayerPrefs.GetInt("Left_Vertical_Joy");
		this.controller_r_h_int = PlayerPrefs.GetInt("Right_Horizontal_Joy");
		this.controller_r_v_int = PlayerPrefs.GetInt("Right_Vertical_Joy");
		this.controller_l_h_i_int = PlayerPrefs.GetInt("Left_Horizontal_Joy_Inv");
		this.controller_l_v_i_int = PlayerPrefs.GetInt("Left_Vertical_Joy_Inv");
		this.controller_r_h_i_int = PlayerPrefs.GetInt("Right_Horizontal_Joy_Inv");
		this.controller_r_v_i_int = PlayerPrefs.GetInt("Right_Vertical_Joy_Inv");
		this.quads[0].renderer.enabled = false;
		this.quads[1].renderer.enabled = false;
		this.quads[2].renderer.enabled = false;
		this.quads[this.quad_selected].renderer.enabled = true;
		this.rigidbody.drag = this.aero_Drag;
		if (this.scene_selected == 0)
		{
			this.max_range = 500;
		}
		else
		{
			this.max_range = 1800;
		}
		this.torque_mult_vfx = (float)1 / (this.torque_multiplier * (float)20);
	}

	public override void FixedUpdate()
	{
		if (this.enable_controller == 0)
		{
			if (this.input_mode == 0)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 1)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 3)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
			}
			else if (this.input_mode == 4)
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_roll = -((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
				this.joy_in_yaw = ((Joystick)this.joystick_right.GetComponent(typeof(Joystick))).position.x;
			}
			else
			{
				this.joy_in_throttle = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.y;
				this.joy_in_pitch = Input.acceleration.y + 0.4f;
				this.joy_in_roll = -Input.acceleration.x;
				this.joy_in_yaw = ((Joystick)this.joystick_left.GetComponent(typeof(Joystick))).position.x;
			}
		}
		else
		{
			this.Axis_[1] = Input.GetAxis("Horizontal");
			this.Axis_[2] = Input.GetAxis("Vertical");
			this.Axis_[3] = Input.GetAxis("Third_Axis");
			this.Axis_[4] = Input.GetAxis("Fourth_Axis");
			this.Axis_[5] = Input.GetAxis("Fifth_Axis");
			this.Axis_[6] = Input.GetAxis("Sixth_Axis");
			this.Axis_[7] = Input.GetAxis("Seventh_Axis");
			this.Axis_[8] = Input.GetAxis("Eighth_Axis");
			this.Axis_[9] = Input.GetAxis("Ninth_Axis");
			this.Axis_[10] = Input.GetAxis("Tenth_Axis");
			if (this.input_mode == 0)
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
			else if (this.input_mode == 1)
			{
				this.joy_in_throttle = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
			else if (this.input_mode == 3)
			{
				this.joy_in_throttle = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
			}
			else if (this.input_mode == 4)
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int;
				this.joy_in_roll = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
				this.joy_in_yaw = this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int;
			}
			else
			{
				this.joy_in_throttle = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int;
				this.joy_in_pitch = Input.acceleration.y + 0.4f;
				this.joy_in_roll = -Input.acceleration.x;
				this.joy_in_yaw = this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int;
			}
		}
		this.in_pitch = this.joy_in_pitch;
		this.in_roll = this.joy_in_roll;
		this.in_yaw = this.joy_in_yaw;
		this.vertical_velocity = this.rigidbody.velocity.y;
		if (this.on_ground && this.vertical_velocity > 0.005f)
		{
			this.on_ground = false;
		}
		if (this.smart_mode && !this.on_ground)
		{
			if (this.roll < (float)0)
			{
				this.roll_balance = -this.roll;
			}
			else
			{
				this.roll_balance = this.roll;
			}
			if (this.pitch < (float)0)
			{
				this.pitch_balance = -this.pitch;
			}
			else
			{
				this.pitch_balance = this.pitch;
			}
			this.auto_stabilize_senstivity = 0.0004f;
			float y = this.transform.position.y;
			Vector3 position = this.GPS_pos.position;
			float num = position.y = y;
			Vector3 vector = this.GPS_pos.position = position;
			this.GPS_pos_dist = Vector3.Distance(this.transform.position, this.GPS_pos.position);
			if (this.GPS_mode)
			{
				if (this.joy_in_pitch == (float)0 && this.joy_in_roll == (float)0 && this.sm_mode != 4)
				{
					if (this.once)
					{
						float x = this.transform.position.x;
						Vector3 position2 = this.GPS_pos.position;
						float num2 = position2.x = x;
						Vector3 vector2 = this.GPS_pos.position = position2;
						float z = this.transform.position.z;
						Vector3 position3 = this.GPS_pos.position;
						float num3 = position3.z = z;
						Vector3 vector3 = this.GPS_pos.position = position3;
						this.old_time = Time.time;
						this.once = false;
					}
					if (this.once_2 && (Time.time > this.old_time + (float)2 || this.rigidbody.velocity.magnitude < 0.5f))
					{
						float x2 = this.transform.position.x;
						Vector3 position4 = this.GPS_pos.position;
						float num4 = position4.x = x2;
						Vector3 vector4 = this.GPS_pos.position = position4;
						float z2 = this.transform.position.z;
						Vector3 position5 = this.GPS_pos.position;
						float num5 = position5.z = z2;
						Vector3 vector5 = this.GPS_pos.position = position5;
						this.old_time = Time.time;
						this.once_2 = false;
					}
					this.angle_move_cal = (float)180;
					this.GPS_pos_angle = this.GPS_pos.eulerAngles.y;
					this.angle_move = this.yaw + this.angle_move_cal - this.GPS_pos_angle;
					this.pitch_roll_magnitude = this.GPS_pos_dist * 0.2f;
					if (this.pitch_roll_magnitude > 0.8f)
					{
						this.pitch_roll_magnitude = 0.8f;
					}
					this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
					this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
				}
				else
				{
					if (this.sm_mode == 3)
					{
						this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
						this.return_home_angle = this.home_point.eulerAngles.y;
						this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
						this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
						this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
						this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
					}
					else if (this.sm_mode == 2)
					{
						this.angle_move_cal = Mathf.Atan2(this.joy_in_roll, this.joy_in_pitch) * 57.29578f;
						this.angle_move = this.yaw + this.angle_move_cal;
						this.pitch_roll_magnitude = Mathf.Sqrt(this.in_pitch * this.in_pitch + this.in_roll * this.in_roll);
						this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
						this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
					}
					else if (this.sm_mode == 4)
					{
						if (this.max_height_reached > (float)100)
						{
							this.level_flight = (float)100;
						}
						else if (this.max_height_reached < (float)15)
						{
							this.level_flight = (float)15;
						}
						else
						{
							this.level_flight = this.max_height_reached;
						}
						this.angle_move_cal = (float)180;
						this.return_home_angle = this.home_point.eulerAngles.y;
						this.angle_move = this.yaw + this.angle_move_cal - this.return_home_angle;
						float x3 = this.home_point_hor.position.x;
						Vector3 position6 = this.GPS_pos.position;
						float num6 = position6.x = x3;
						Vector3 vector6 = this.GPS_pos.position = position6;
						float z3 = this.home_point_hor.position.z;
						Vector3 position7 = this.GPS_pos.position;
						float num7 = position7.z = z3;
						Vector3 vector7 = this.GPS_pos.position = position7;
						this.home_distance_hor = Vector3.Distance(this.transform.position, this.home_point_hor.position);
						this.pitch_roll_magnitude = this.home_distance_hor * 0.3f;
						if (this.home_distance_hor < (float)3)
						{
							this.level_flight = this.transform.position.y;
							if (this.transform.position.y - this.home_point.position.y < (float)3)
							{
								this.joy_in_throttle = -0.02f;
							}
							else
							{
								this.joy_in_throttle = -0.1f;
							}
						}
						if (this.pitch_roll_magnitude > 0.8f)
						{
							this.pitch_roll_magnitude = 0.8f;
						}
						int layerMask = -2049;
						RaycastHit raycastHit = default(RaycastHit);
						if (Physics.Raycast(this.transform.position, -Vector3.up, out raycastHit, (float)20, layerMask))
						{
							this.distanceToGround = raycastHit.distance;
							if (this.distanceToGround < 0.1f && this.vertical_velocity > -0.01f && this.vertical_velocity < 0.01f)
							{
								this.on_ground = true;
							}
						}
						this.in_pitch = this.pitch_roll_magnitude * Mathf.Cos(0.0174532924f * this.angle_move);
						this.in_roll = this.pitch_roll_magnitude * Mathf.Sin(0.0174532924f * this.angle_move);
					}
					else
					{
						this.in_pitch = this.joy_in_pitch;
						this.in_roll = this.joy_in_roll;
					}
					this.once = true;
					this.once_2 = true;
				}
			}
			if (this.joy_in_throttle < 0.005f && this.joy_in_throttle > -0.005f)
			{
				if (this.countii == 0)
				{
					this.level_flight = this.transform.position.y;
					this.countii = 1;
				}
				if (this.counti == 0 && this.vertical_velocity < 0.2f && this.vertical_velocity > -0.2f)
				{
					this.level_flight = this.transform.position.y;
					this.counti = 1;
				}
				this.vertical_hold = this.level_flight - this.transform.position.y;
			}
			else
			{
				this.vertical_hold = (float)0;
				this.counti = 0;
				this.countii = 0;
			}
			this.in_throttle = 9.8f * this.rigidbody.mass * 0.25f / this.torque_multiplier + this.vertical_hold * 0.6f - this.vertical_velocity * 0.1f + this.joy_in_throttle * (float)2;
			if (this.in_throttle > (float)2)
			{
				this.in_throttle = (float)2;
			}
			if (this.in_throttle < 0.1f)
			{
				this.in_throttle = 0.1f;
			}
		}
		else
		{
			if (this.altitude_hold)
			{
				this.in_throttle = 9.8f * this.rigidbody.mass * 0.25f / this.torque_multiplier + (this.level_flight - this.transform.position.y) * (float)2 - this.rigidbody.velocity.y;
				if (this.in_throttle > (float)2)
				{
					this.in_throttle = (float)2;
				}
				if (this.in_throttle < (float)0)
				{
					this.in_throttle = (float)0;
				}
			}
			else
			{
				this.in_throttle = this.joy_in_throttle + (float)1;
				if (this.on_ground && this.joy_in_throttle == (float)0)
				{
					this.in_throttle -= 0.3f;
				}
			}
			this.in_pitch = this.joy_in_pitch;
			this.in_roll = this.joy_in_roll;
			this.in_yaw = this.joy_in_yaw;
			this.auto_stabilize_senstivity = this.auto_stabilize_senst;
		}
		if (this.transform.rotation.eulerAngles.x >= (float)180)
		{
			this.pitch = this.transform.rotation.eulerAngles.x - (float)360;
		}
		else
		{
			this.pitch = this.transform.rotation.eulerAngles.x;
		}
		if (this.transform.rotation.eulerAngles.z >= (float)180)
		{
			this.roll = this.transform.rotation.eulerAngles.z - (float)360;
		}
		else
		{
			this.roll = this.transform.rotation.eulerAngles.z;
		}
		this.yaw = this.transform.eulerAngles.y;
		this.Stabilize_pitch = this.auto_stabilize_senstivity;
		this.Stabilize_roll = this.auto_stabilize_senstivity;
		if (this.altitude_hold || this.auto_stabilize_senstivity > 0.00019f)
		{
			this.Stabilize_pitch = this.auto_stabilize_senstivity;
			this.Stabilize_roll = this.auto_stabilize_senstivity;
		}
		else
		{
			this.Stabilize_roll = this.auto_stabilize_senstivity;
			this.Stabilize_pitch = this.auto_stabilize_senstivity;
			if (this.in_roll >= (float)0)
			{
				this.Stabilize_roll = this.auto_stabilize_senstivity * ((float)1 - this.in_roll);
			}
			if (this.in_roll < (float)0)
			{
				this.Stabilize_roll = this.auto_stabilize_senstivity * ((float)1 + this.in_roll);
			}
			if (this.in_pitch >= (float)0)
			{
				this.Stabilize_pitch = this.auto_stabilize_senstivity * ((float)1 - this.in_pitch);
			}
			if (this.in_pitch < (float)0)
			{
				this.Stabilize_pitch = this.auto_stabilize_senstivity * ((float)1 + this.in_pitch);
			}
			if (this.in_pitch >= 0.95f || this.in_pitch < -0.95f || this.in_roll >= 0.95f || this.in_roll < -0.95f)
			{
				this.Stabilize_pitch = (float)0;
				this.Stabilize_roll = (float)0;
			}
		}
		this.motor_torque_front_left = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstivity;
		this.motor_torque_front_right = this.in_throttle * this.torque_multiplier - this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity + this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstivity;
		this.motor_torque_rear_left = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity - this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch + this.roll * this.Stabilize_roll - this.in_yaw * this.control_senstivity;
		this.motor_torque_rear_right = this.in_throttle * this.torque_multiplier + this.in_pitch * this.control_senstivity + this.in_roll * this.control_senstivity - this.pitch * this.Stabilize_pitch - this.roll * this.Stabilize_roll + this.in_yaw * this.control_senstivity;
		this.rigidbody.AddForceAtPosition(this.transform.up * this.motor_torque_front_left * (float)this.coll_front_left * (float)this.high_speed_collision, this.prop_front_left.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * this.motor_torque_front_right * (float)this.coll_front_right * (float)this.high_speed_collision, this.prop_front_right.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * this.motor_torque_rear_left * (float)this.coll_rear_left * (float)this.high_speed_collision, this.prop_rear_left.position);
		this.rigidbody.AddForceAtPosition(this.transform.up * this.motor_torque_rear_right * (float)this.coll_rear_right * (float)this.high_speed_collision, this.prop_rear_right.position);
		this.rigidbody.AddRelativeTorque((float)0, this.in_yaw * this.control_senstive_yaw * this.in_throttle, (float)0);
		this.particle_effects.particleSystem.emissionRate = (float)0;
		this.ground_effect_multiplier = (float)0;
		this.particle_effects.gameObject.SetActive(false);
	}

	public override void LateUpdate()
	{
		if (this.rigidbody.position.y > this.max_height_reached)
		{
			this.max_height_reached = this.rigidbody.position.y;
		}
		this.coll_front_left = ((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll;
		this.coll_front_right = ((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll;
		this.coll_rear_left = ((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll;
		this.coll_rear_right = ((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll;
		if (this.motor_torque_front_left > 0.15f && this.coll_front_left == 0)
		{
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[0] = "Prop Front Left Broken \n";
			this.text_print();
		}
		if (this.motor_torque_front_right > 0.15f && this.coll_front_right == 0)
		{
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[1] = "Prop Front Right Broken \n";
			this.text_print();
		}
		if (this.motor_torque_rear_left > 0.15f && this.coll_rear_left == 0)
		{
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[2] = "Prop Rear Left Broken \n";
			this.text_print();
		}
		if (this.motor_torque_rear_right > 0.15f && this.coll_rear_right == 0)
		{
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
			this.text_display[3] = "Prop Rear Right Broken \n";
			this.text_print();
		}
		this.prop_front_left.Rotate((float)0, (float)0, this.motor_torque_front_left * (float)this.coll_front_left * (float)this.high_speed_collision * (float)-3000 * this.torque_mult_vfx);
		this.prop_front_right.Rotate((float)0, (float)0, this.motor_torque_front_right * (float)this.coll_front_right * (float)this.high_speed_collision * (float)3000 * this.torque_mult_vfx);
		this.prop_rear_left.Rotate((float)0, (float)0, this.motor_torque_rear_left * (float)this.coll_rear_left * (float)this.high_speed_collision * (float)3000 * this.torque_mult_vfx);
		this.prop_rear_right.Rotate((float)0, (float)0, this.motor_torque_rear_right * (float)this.coll_rear_right * (float)this.high_speed_collision * (float)-3000 * this.torque_mult_vfx);
		float a = this.motor_torque_front_left * (float)this.coll_front_left * (float)15 * this.torque_mult_vfx;
		Color color = this.prop_front_left.renderer.materials[0].color;
		float num = color.a = a;
		Color color2 = this.prop_front_left.renderer.materials[0].color = color;
		float a2 = this.motor_torque_front_right * (float)this.coll_front_right * (float)15 * this.torque_mult_vfx;
		Color color3 = this.prop_front_right.renderer.materials[0].color;
		float num2 = color3.a = a2;
		Color color4 = this.prop_front_right.renderer.materials[0].color = color3;
		float a3 = this.motor_torque_rear_left * (float)this.coll_rear_left * (float)15 * this.torque_mult_vfx;
		Color color5 = this.prop_rear_left.renderer.materials[0].color;
		float num3 = color5.a = a3;
		Color color6 = this.prop_rear_left.renderer.materials[0].color = color5;
		float a4 = this.motor_torque_rear_right * (float)this.coll_rear_right * (float)15 * this.torque_mult_vfx;
		Color color7 = this.prop_rear_right.renderer.materials[0].color;
		float num4 = color7.a = a4;
		Color color8 = this.prop_rear_right.renderer.materials[0].color = color7;
		float a5 = (float)1 - this.motor_torque_front_left * (float)this.coll_front_left * (float)15 * this.torque_mult_vfx;
		Color color9 = this.prop_front_left.renderer.materials[1].color;
		float num5 = color9.a = a5;
		Color color10 = this.prop_front_left.renderer.materials[1].color = color9;
		float a6 = (float)1 - this.motor_torque_front_right * (float)this.coll_front_right * (float)15 * this.torque_mult_vfx;
		Color color11 = this.prop_front_right.renderer.materials[1].color;
		float num6 = color11.a = a6;
		Color color12 = this.prop_front_right.renderer.materials[1].color = color11;
		float a7 = (float)1 - this.motor_torque_rear_left * (float)this.coll_rear_left * (float)15 * this.torque_mult_vfx;
		Color color13 = this.prop_rear_left.renderer.materials[1].color;
		float num7 = color13.a = a7;
		Color color14 = this.prop_rear_left.renderer.materials[1].color = color13;
		float a8 = (float)1 - this.motor_torque_rear_right * (float)this.coll_rear_right * (float)15 * this.torque_mult_vfx;
		Color color15 = this.prop_rear_right.renderer.materials[1].color;
		float num8 = color15.a = a8;
		Color color16 = this.prop_rear_right.renderer.materials[1].color = color15;
		this.prop_front_left.audio.pitch = this.motor_torque_front_left * this.pitch_multiplier * this.torque_mult_vfx;
		this.prop_front_right.audio.pitch = this.motor_torque_front_right * this.pitch_multiplier * this.torque_mult_vfx;
		this.prop_rear_left.audio.pitch = this.motor_torque_rear_left * this.pitch_multiplier * this.torque_mult_vfx;
		this.prop_rear_right.audio.pitch = this.motor_torque_rear_right * this.pitch_multiplier * this.torque_mult_vfx;
		this.prop_front_left.audio.volume = this.motor_torque_front_left * this.volume_multiplier * this.torque_mult_vfx;
		this.prop_front_right.audio.volume = this.motor_torque_front_right * this.volume_multiplier * this.torque_mult_vfx;
		this.prop_rear_left.audio.volume = this.motor_torque_rear_left * this.volume_multiplier * this.torque_mult_vfx;
		this.prop_rear_right.audio.volume = this.motor_torque_rear_right * this.volume_multiplier * this.torque_mult_vfx;
		float num9 = Vector3.Distance(this.transform.position, this.controller_location.position);
		if (num9 > (float)this.max_range)
		{
			Application.LoadLevel(0);
		}
		if (num9 > (float)(this.max_range - 150))
		{
			this.text_display[4] = "Nearing Max. Range, Return Back\n";
			this.text_print();
		}
		if (num9 < (float)(this.max_range - 150))
		{
			this.text_display[4] = "\n";
			this.text_print();
		}
		if (num9 > (float)100 && !this.cam_human.gameObject.activeSelf)
		{
			float x = num9 * 0.01f * 0.5f + 0.5f;
			Vector3 localScale = this.mountains.transform.localScale;
			float num10 = localScale.x = x;
			Vector3 vector = this.mountains.transform.localScale = localScale;
			float y = num9 * 0.01f * 0.5f + 0.5f;
			Vector3 localScale2 = this.mountains.transform.localScale;
			float num11 = localScale2.y = y;
			Vector3 vector2 = this.mountains.transform.localScale = localScale2;
			float z = num9 * 0.01f * 0.5f + 0.5f;
			Vector3 localScale3 = this.mountains.transform.localScale;
			float num12 = localScale3.z = z;
			Vector3 vector3 = this.mountains.transform.localScale = localScale3;
		}
		else
		{
			int num13 = 1;
			Vector3 localScale4 = this.mountains.transform.localScale;
			float num14 = localScale4.x = (float)num13;
			Vector3 vector4 = this.mountains.transform.localScale = localScale4;
			int num15 = 1;
			Vector3 localScale5 = this.mountains.transform.localScale;
			float num16 = localScale5.y = (float)num15;
			Vector3 vector5 = this.mountains.transform.localScale = localScale5;
			int num17 = 1;
			Vector3 localScale6 = this.mountains.transform.localScale;
			float num18 = localScale6.z = (float)num17;
			Vector3 vector6 = this.mountains.transform.localScale = localScale6;
		}
		if (this.scene_selected == 1 && this.rigidbody.position.y < -7.45f)
		{
			this.text_display[5] = "Splash.....\n";
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
		if (this.scene_selected == 2 && this.rigidbody.position.y < -1f)
		{
			this.text_display[5] = "Splash.....\n";
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
	}

	public override void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.magnitude > (float)15)
		{
			this.text_display[5] = "High Speed CRASH.....\n";
			this.text_print();
			this.high_speed_collision = 0;
			((Prop)this.prop_front_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_front_right.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_left.GetComponent(typeof(Prop))).coll_back = 1;
			((Prop)this.prop_rear_right.GetComponent(typeof(Prop))).coll_back = 1;
		}
	}

	public override void text_print()
	{
		this.warning_display.guiText.text = this.text_display[0] + this.text_display[1] + this.text_display[2] + this.text_display[3] + this.text_display[4] + this.text_display[5];
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Quad_Select : MonoBehaviour
{
	public Transform[] quads;

	public int quad_selected;

	public Transform select_button_T;

	public Transform buy_button_T;

	public Transform text_heading;

	public Transform text_weight;

	public Transform text_thrust;

	public Transform Main_Camera;

	private int sl_w;

	private int sl_h;

	private int[] isPurchased;

	private float[] Thrust_M;

	private float[] Mass_M;

	private string units_standard;

	private string units_Force;

	private string units_Weight;

	private float units_Force_m;

	private float units_Weight_m;

	private string[] Quad_Names;

	private bool VR_on;

	public Transform VR_camera;

	public Transform canvas_events;

	public Transform Canvas_T;

	public Transform main_cam;

	public Quad_Select()
	{
		this.quads = new Transform[3];
		this.isPurchased = new int[3];
		this.Thrust_M = new float[3];
		this.Mass_M = new float[3];
		this.units_standard = "Imperial";
		this.units_Force = "lbf";
		this.units_Weight = "lb";
		this.units_Force_m = 2.2046f;
		this.units_Weight_m = 2.2046f;
		this.Quad_Names = new string[3];
	}

	public override void Start()
	{
		this.load_values();
		this.Quad_Names[0] = "Default Quad";
		this.Quad_Names[1] = "Quad UFO";
		this.Quad_Names[2] = "Quad Home Built";
		if (this.units_standard == "Imperial")
		{
			this.units_Force = "lbf";
			this.units_Weight = "lb";
			this.units_Force_m = 2.2046f;
			this.units_Weight_m = 2.2046f;
		}
		else
		{
			this.units_Force = "Kgf";
			this.units_Weight = "Kg";
			this.units_Force_m = (float)1;
			this.units_Weight_m = (float)1;
		}
		this.quads[0].GetComponent<Renderer>().enabled = false;
		this.quads[1].GetComponent<Renderer>().enabled = false;
		this.quads[2].GetComponent<Renderer>().enabled = false;
		this.quads[this.quad_selected].GetComponent<Renderer>().enabled = true;
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.main_cam.gameObject.SetActive(false);
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.Main_Camera.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			this.main_cam.gameObject.SetActive(true);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.Main_Camera.gameObject.SetActive(true);
		}
	}

	public override void Update()
	{
		((Text)this.text_heading.gameObject.GetComponent(typeof(Text))).text = this.Quad_Names[this.quad_selected];
		((Text)this.text_weight.gameObject.GetComponent(typeof(Text))).text = "Total Weight " + (this.Mass_M[this.quad_selected] * 9.8f * this.units_Weight_m).ToString("f2") + " " + this.units_Weight;
		((Text)this.text_thrust.gameObject.GetComponent(typeof(Text))).text = "Max. Combined Thrust " + (this.Thrust_M[this.quad_selected] * this.units_Force_m * (float)2 * (float)4).ToString("f2") + " " + this.units_Force;
		if (this.isPurchased[this.quad_selected] == 1)
		{
			this.select_button_T.gameObject.SetActive(true);
			this.buy_button_T.gameObject.SetActive(false);
		}
		else
		{
			this.select_button_T.gameObject.SetActive(false);
			this.buy_button_T.gameObject.SetActive(true);
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(1);
		}
	}

	public override void load_values()
	{
		this.units_standard = PlayerPrefs.GetString("Units");
		this.isPurchased[0] = PlayerPrefs.GetInt("Quad_Purchased_Q0");
		this.isPurchased[1] = PlayerPrefs.GetInt("Quad_Purchased_Q1");
		this.isPurchased[2] = PlayerPrefs.GetInt("Quad_Purchased_Q2");
		this.quad_selected = PlayerPrefs.GetInt("Quad");
		this.Thrust_M[0] = PlayerPrefs.GetFloat("Thrust_Multiplier_Q0");
		this.Thrust_M[1] = PlayerPrefs.GetFloat("Thrust_Multiplier_Q1");
		this.Thrust_M[2] = PlayerPrefs.GetFloat("Thrust_Multiplier_Q2");
		this.Mass_M[0] = PlayerPrefs.GetFloat("Mass_Multiplier_Q0");
		this.Mass_M[1] = PlayerPrefs.GetFloat("Mass_Multiplier_Q1");
		this.Mass_M[2] = PlayerPrefs.GetFloat("Mass_Multiplier_Q2");
		this.Thrust_M[this.quad_selected] = PlayerPrefs.GetFloat("Thrust_Multiplier");
		this.Mass_M[this.quad_selected] = PlayerPrefs.GetFloat("Mass_Multiplier");
	}

	public override void save_values()
	{
		PlayerPrefs.SetInt("Quad", this.quad_selected);
		PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", this.Thrust_M[0]);
		PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", this.Thrust_M[1]);
		PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", this.Thrust_M[2]);
		PlayerPrefs.SetFloat("Mass_Multiplier_Q0", this.Mass_M[0]);
		PlayerPrefs.SetFloat("Mass_Multiplier_Q1", this.Mass_M[1]);
		PlayerPrefs.SetFloat("Mass_Multiplier_Q2", this.Mass_M[2]);
		PlayerPrefs.SetFloat("Thrust_Multiplier", this.Thrust_M[this.quad_selected]);
		PlayerPrefs.SetFloat("Mass_Multiplier", this.Mass_M[this.quad_selected]);
	}

	public override void next_button()
	{
		if (this.quad_selected == 2)
		{
			this.quad_selected = 0;
		}
		else
		{
			this.quad_selected++;
		}
		this.quads[0].GetComponent<Renderer>().enabled = false;
		this.quads[1].GetComponent<Renderer>().enabled = false;
		this.quads[2].GetComponent<Renderer>().enabled = false;
		this.quads[this.quad_selected].GetComponent<Renderer>().enabled = true;
	}

	public override void previous_button()
	{
		if (this.quad_selected == 0)
		{
			this.quad_selected = 2;
		}
		else
		{
			this.quad_selected--;
		}
		this.quads[0].GetComponent<Renderer>().enabled = false;
		this.quads[1].GetComponent<Renderer>().enabled = false;
		this.quads[2].GetComponent<Renderer>().enabled = false;
		this.quads[this.quad_selected].GetComponent<Renderer>().enabled = true;
	}

	public override void buy_button()
	{
		Application.LoadLevel(10);
	}

	public override void select_button()
	{
		this.save_values();
		Application.LoadLevel(1);
	}

	public override void cancel_button()
	{
		Application.LoadLevel(1);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Quit_Page : MonoBehaviour
{
	private bool VR_on;

	public Transform VR_camera;

	public Transform canvas_events;

	public Transform Canvas_T;

	public Transform Main_Camera;

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.Main_Camera.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.Main_Camera.gameObject.SetActive(true);
		}
	}

	public override void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
	}

	public override void Quit_button()
	{
		Application.Quit();
	}

	public override void cancel_button()
	{
		Application.LoadLevel(0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Reset : MonoBehaviour
{
	private int scene_selected;

	private int Trial_Time_1;

	private int Trial_Time_2;

	private float scene_time;

	private int height_pos;

	private int width_pos;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.scene_time = Time.time;
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		this.width_pos = (int)((float)Screen.height / 4.2f);
		this.height_pos = Screen.height / 60;
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2 - (float)this.width_pos;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num3 = pixelInset3.x = x;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		int num4 = this.height_pos;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num5 = pixelInset4.y = (float)num4;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_reset();
				}
			}
		}
		if (Input.GetButtonDown("Reset"))
		{
			this.execute_reset();
		}
	}

	public override void execute_reset()
	{
		if (this.scene_selected == 1 && this.Trial_Time_1 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S1", (int)((float)this.Trial_Time_1 + Time.time - this.scene_time));
		}
		if (this.scene_selected == 2 && this.Trial_Time_2 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S2", (int)((float)this.Trial_Time_2 + Time.time - this.scene_time));
		}
		Application.LoadLevel(0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Return_button : MonoBehaviour
{
	public Transform Quadcopter;

	public Transform butt_off;

	private int height_pos;

	public override void Start()
	{
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f + this.guiTexture.pixelInset.height * 3.75f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 4)
		{
			float a = 0.5f;
			Color color = this.guiTexture.color;
			float num = color.a = a;
			Color color2 = this.guiTexture.color = color;
			int num2 = 0;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = (float)num2;
			Color color4 = this.butt_off.guiTexture.color = color3;
		}
		else
		{
			int num4 = 0;
			Color color5 = this.guiTexture.color;
			float num5 = color5.a = (float)num4;
			Color color6 = this.guiTexture.color = color5;
			float a2 = 0.5f;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = a2;
			Color color8 = this.butt_off.guiTexture.color = color7;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_rtl();
				}
			}
		}
		if (Input.GetButtonDown("RTL"))
		{
			this.execute_rtl();
		}
	}

	public override void execute_rtl()
	{
		if (((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 4)
		{
			((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 1;
		}
		else
		{
			((Quad_Dynamics_independent_propeller)this.Quadcopter.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode = 4;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[Serializable]
public class RollABall : MonoBehaviour
{
	public Vector3 tilt;

	public float speed;

	private float circ;

	private Vector3 previousPosition;

	public RollABall()
	{
		this.tilt = Vector3.zero;
	}

	public override void Start()
	{
		this.circ = 6.28318548f * this.collider.bounds.extents.x;
		this.previousPosition = this.transform.position;
	}

	public override void Update()
	{
		this.tilt.x = -Input.acceleration.y;
		this.tilt.z = Input.acceleration.x;
		this.rigidbody.AddForce(this.tilt * this.speed * Time.deltaTime);
	}

	public override void LateUpdate()
	{
		Vector3 a = this.transform.position - this.previousPosition;
		a = new Vector3(a.z, (float)0, -a.x);
		this.transform.Rotate(a / this.circ * (float)360, Space.World);
		this.previousPosition = this.transform.position;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Rotate : MonoBehaviour
{
	public override void Start()
	{
	}

	public override void FixedUpdate()
	{
		this.transform.Rotate((float)0, (float)1, (float)0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class RotationConstraint : MonoBehaviour
{
	public ConstraintAxis axis;

	public float min;

	public float max;

	private Transform thisTransform;

	private Vector3 rotateAround;

	private Quaternion minQuaternion;

	private Quaternion maxQuaternion;

	private float range;

	public override void Start()
	{
		this.thisTransform = this.transform;
		ConstraintAxis constraintAxis = this.axis;
		if (constraintAxis == ConstraintAxis.X)
		{
			this.rotateAround = Vector3.right;
		}
		else if (constraintAxis == ConstraintAxis.Y)
		{
			this.rotateAround = Vector3.up;
		}
		else if (constraintAxis == ConstraintAxis.Z)
		{
			this.rotateAround = Vector3.forward;
		}
		Quaternion lhs = Quaternion.AngleAxis(this.thisTransform.localRotation.eulerAngles[(int)this.axis], this.rotateAround);
		this.minQuaternion = lhs * Quaternion.AngleAxis(this.min, this.rotateAround);
		this.maxQuaternion = lhs * Quaternion.AngleAxis(this.max, this.rotateAround);
		this.range = this.max - this.min;
	}

	public override void LateUpdate()
	{
		Quaternion localRotation = this.thisTransform.localRotation;
		Quaternion a = Quaternion.AngleAxis(localRotation.eulerAngles[(int)this.axis], this.rotateAround);
		float num = Quaternion.Angle(a, this.minQuaternion);
		float num2 = Quaternion.Angle(a, this.maxQuaternion);
		if (num > this.range || num2 > this.range)
		{
			Vector3 eulerAngles = localRotation.eulerAngles;
			if (num > num2)
			{
				eulerAngles[(int)this.axis] = this.maxQuaternion.eulerAngles[(int)this.axis];
			}
			else
			{
				eulerAngles[(int)this.axis] = this.minQuaternion.eulerAngles[(int)this.axis];
			}
			this.thisTransform.localEulerAngles = eulerAngles;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Scene_Load : MonoBehaviour
{
	public Transform Scene_0;

	public Transform Scene_1;

	public Transform Scene_2;

	public Transform Scene_3;

	public Transform challenges_button;

	public Transform Walk_on;

	public Transform Walk_off;

	public Transform Joy_Center;

	public Transform challenges;

	private int scene_selected;

	public int Trial_Time_1;

	public int Trial_Time_2;

	private int Scene_Purchased_1;

	private int Scene_Purchased_2;

	private float scene_time;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.Scene_Purchased_1 = PlayerPrefs.GetInt("Scene_Purchased_S1");
		this.Scene_Purchased_2 = PlayerPrefs.GetInt("Scene_Purchased_S2");
		if (this.scene_selected == 1)
		{
			this.Scene_0.gameObject.SetActive(false);
			this.Scene_1.gameObject.SetActive(true);
			this.Scene_2.gameObject.SetActive(false);
			this.Scene_3.gameObject.SetActive(false);
			this.challenges_button.gameObject.SetActive(false);
			this.Walk_on.gameObject.SetActive(false);
			this.Walk_off.gameObject.SetActive(false);
			this.Joy_Center.gameObject.SetActive(false);
			this.challenges.gameObject.SetActive(false);
		}
		else if (this.scene_selected == 2)
		{
			this.Scene_0.gameObject.SetActive(false);
			this.Scene_1.gameObject.SetActive(false);
			this.Scene_2.gameObject.SetActive(true);
			this.Scene_3.gameObject.SetActive(false);
			this.challenges_button.gameObject.SetActive(false);
			this.Walk_on.gameObject.SetActive(false);
			this.Walk_off.gameObject.SetActive(false);
			this.Joy_Center.gameObject.SetActive(false);
			this.challenges.gameObject.SetActive(false);
		}
		else if (this.scene_selected == 3)
		{
			this.Scene_0.gameObject.SetActive(false);
			this.Scene_1.gameObject.SetActive(false);
			this.Scene_2.gameObject.SetActive(false);
			this.Scene_3.gameObject.SetActive(true);
			this.challenges_button.gameObject.SetActive(false);
			this.Walk_on.gameObject.SetActive(false);
			this.Walk_off.gameObject.SetActive(false);
			this.Joy_Center.gameObject.SetActive(false);
			this.challenges.gameObject.SetActive(false);
		}
		else
		{
			this.Scene_0.gameObject.SetActive(true);
			this.Scene_1.gameObject.SetActive(false);
			this.Scene_2.gameObject.SetActive(false);
			this.Scene_3.gameObject.SetActive(false);
		}
		this.scene_time = Time.time;
	}

	public override void Update()
	{
		if (this.scene_selected == 1 && this.Scene_Purchased_1 == 0 && (float)this.Trial_Time_1 + Time.time - this.scene_time >= (float)120)
		{
			PlayerPrefs.SetInt("Scene_Try_S1", 1);
			PlayerPrefs.SetInt("Scene_Try_Time_S1", 120);
			PlayerPrefs.SetInt("Scene", 0);
			Application.LoadLevel(7);
		}
		if (this.scene_selected == 2 && this.Scene_Purchased_2 == 0 && (float)this.Trial_Time_2 + Time.time - this.scene_time >= (float)120)
		{
			PlayerPrefs.SetInt("Scene_Try_S2", 1);
			PlayerPrefs.SetInt("Scene_Try_Time_S2", 120);
			PlayerPrefs.SetInt("Scene", 0);
			Application.LoadLevel(7);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Scene_Select : MonoBehaviour
{
	public GUISkin customSkin_lowres;

	public GUISkin customSkin_medres;

	public GUISkin customSkin_highres;

	public Transform select_button_T;

	public Transform buy_button_T;

	public Transform try_button_T;

	public Transform text_heading;

	public Transform text_detail;

	public Transform text_time_try;

	public Transform Main_Camera;

	private GUISkin customSkin;

	public Transform scene;

	public int scene_selected;

	private int sl_w;

	private int sl_h;

	private int[] isPurchased;

	private int[] isTrial;

	private int[] Trial_Time;

	private string[] Scene_Names;

	private string[] Scene_Dis;

	private bool VR_on;

	public Transform VR_camera;

	public Transform canvas_events;

	public Transform Canvas_T;

	public Transform main_cam;

	public Scene_Select()
	{
		this.isPurchased = new int[4];
		this.isTrial = new int[4];
		this.Trial_Time = new int[4];
		this.Scene_Names = new string[4];
		this.Scene_Dis = new string[4];
	}

	public override void Start()
	{
		this.load_values();
		this.Scene_Names[0] = "Old Factory";
		this.Scene_Names[1] = "Paradise Island";
		this.Scene_Names[2] = "Open Sea";
		this.Scene_Names[3] = "Desert";
		this.Scene_Dis[0] = "Default Scene";
		this.Scene_Dis[1] = "This Scene might not run smoothly on mobile devices due to high details";
		this.Scene_Dis[2] = "A nice sea environment with boats";
		this.Scene_Dis[3] = "This is Very Simple Scene without any Obstacles";
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.main_cam.gameObject.SetActive(false);
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.Main_Camera.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			this.main_cam.gameObject.SetActive(true);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.Main_Camera.gameObject.SetActive(true);
		}
	}

	public override void Update()
	{
		((Text)this.text_heading.gameObject.GetComponent(typeof(Text))).text = this.Scene_Names[this.scene_selected];
		((Text)this.text_detail.gameObject.GetComponent(typeof(Text))).text = this.Scene_Dis[this.scene_selected];
		if (this.scene_selected == 0)
		{
			float y = Mathf.Lerp(this.scene.eulerAngles.y, (float)0, Time.deltaTime * (float)5);
			Vector3 eulerAngles = this.scene.eulerAngles;
			float num = eulerAngles.y = y;
			Vector3 vector = this.scene.eulerAngles = eulerAngles;
		}
		if (this.scene_selected == 1)
		{
			float y2 = Mathf.Lerp(this.scene.eulerAngles.y, (float)90, Time.deltaTime * (float)5);
			Vector3 eulerAngles2 = this.scene.eulerAngles;
			float num2 = eulerAngles2.y = y2;
			Vector3 vector2 = this.scene.eulerAngles = eulerAngles2;
		}
		if (this.scene_selected == 2)
		{
			float y3 = Mathf.Lerp(this.scene.eulerAngles.y, (float)180, Time.deltaTime * (float)5);
			Vector3 eulerAngles3 = this.scene.eulerAngles;
			float num3 = eulerAngles3.y = y3;
			Vector3 vector3 = this.scene.eulerAngles = eulerAngles3;
		}
		if (this.scene_selected == 3)
		{
			float y4 = Mathf.Lerp(this.scene.eulerAngles.y, (float)270, Time.deltaTime * (float)5);
			Vector3 eulerAngles4 = this.scene.eulerAngles;
			float num4 = eulerAngles4.y = y4;
			Vector3 vector4 = this.scene.eulerAngles = eulerAngles4;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(1);
		}
		if (this.isPurchased[this.scene_selected] == 1)
		{
			this.select_button_T.gameObject.SetActive(true);
			this.buy_button_T.gameObject.SetActive(false);
			((Text)this.text_time_try.gameObject.GetComponent(typeof(Text))).text = string.Empty;
			this.try_button_T.gameObject.SetActive(false);
		}
		else
		{
			this.select_button_T.gameObject.SetActive(false);
			this.buy_button_T.gameObject.SetActive(true);
			if (this.isTrial[this.scene_selected] == 0)
			{
				((Text)this.text_time_try.gameObject.GetComponent(typeof(Text))).text = "Trial time left " + (120 - this.Trial_Time[this.scene_selected]).ToString() + " Sec.";
				this.try_button_T.gameObject.SetActive(true);
			}
			else
			{
				((Text)this.text_time_try.gameObject.GetComponent(typeof(Text))).text = "Trial Over";
				this.try_button_T.gameObject.SetActive(false);
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(1);
		}
	}

	public override void load_values()
	{
		this.isPurchased[0] = PlayerPrefs.GetInt("Scene_Purchased_S0");
		this.isPurchased[1] = PlayerPrefs.GetInt("Scene_Purchased_S1");
		this.isPurchased[2] = PlayerPrefs.GetInt("Scene_Purchased_S2");
		this.isPurchased[3] = PlayerPrefs.GetInt("Scene_Purchased_S3");
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.isTrial[0] = PlayerPrefs.GetInt("Scene_Try_S0");
		this.isTrial[1] = PlayerPrefs.GetInt("Scene_Try_S1");
		this.isTrial[2] = PlayerPrefs.GetInt("Scene_Try_S2");
		this.isTrial[3] = PlayerPrefs.GetInt("Scene_Try_S3");
		this.Trial_Time[0] = PlayerPrefs.GetInt("Scene_Try_Time_S0");
		this.Trial_Time[1] = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time[2] = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.Trial_Time[3] = PlayerPrefs.GetInt("Scene_Try_Time_S3");
	}

	public override void save_values()
	{
		PlayerPrefs.SetInt("Scene", this.scene_selected);
	}

	public override void next_button()
	{
		if (this.scene_selected == 3)
		{
			this.scene_selected = 0;
		}
		else
		{
			this.scene_selected++;
		}
	}

	public override void previous_button()
	{
		if (this.scene_selected == 0)
		{
			this.scene_selected = 3;
		}
		else
		{
			this.scene_selected--;
		}
	}

	public override void buy_button()
	{
		Application.LoadLevel(10);
	}

	public override void select_button()
	{
		this.save_values();
		Application.LoadLevel(0);
	}

	public override void cancel_button()
	{
		Application.LoadLevel(1);
	}

	public override void try_button()
	{
		this.save_values();
		Application.LoadLevel(0);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Settings : MonoBehaviour
{
	private int scene_selected;

	private int Trial_Time_1;

	private int Trial_Time_2;

	private float scene_time;

	private int height_pos;

	private int width_pos;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.scene_time = Time.time;
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		this.width_pos = (int)((float)Screen.height / 4.2f);
		this.height_pos = Screen.height / 60;
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2 + (float)this.width_pos;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num3 = pixelInset3.x = x;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		int num4 = this.height_pos;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num5 = pixelInset4.y = (float)num4;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_settings();
				}
			}
		}
		if (Input.GetButtonDown("Settings"))
		{
			this.execute_settings();
		}
	}

	public override void execute_settings()
	{
		if (this.scene_selected == 1 && this.Trial_Time_1 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S1", (int)((float)this.Trial_Time_1 + Time.time - this.scene_time));
		}
		if (this.scene_selected == 2 && this.Trial_Time_2 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S2", (int)((float)this.Trial_Time_2 + Time.time - this.scene_time));
		}
		Application.LoadLevel(1);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class shadow_follow : MonoBehaviour
{
	public Transform follow_object;

	public float follow_height;

	public override void Start()
	{
	}

	public override void Update()
	{
		float x = this.follow_object.transform.position.x;
		Vector3 position = this.transform.position;
		float num = position.x = x;
		Vector3 vector = this.transform.position = position;
		float y = this.follow_object.transform.position.y + this.follow_height;
		Vector3 position2 = this.transform.position;
		float num2 = position2.y = y;
		Vector3 vector2 = this.transform.position = position2;
		float z = this.follow_object.transform.position.z;
		Vector3 position3 = this.transform.position;
		float num3 = position3.z = z;
		Vector3 vector3 = this.transform.position = position3;
		float y2 = this.follow_object.transform.eulerAngles.y;
		Vector3 eulerAngles = this.transform.eulerAngles;
		float num4 = eulerAngles.y = y2;
		Vector3 vector4 = this.transform.eulerAngles = eulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[Serializable]
public class SidescrollControl : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick jumpTouchPad;

	public float forwardSpeed;

	public float backwardSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 velocity;

	private bool canJump;

	public SidescrollControl()
	{
		this.forwardSpeed = (float)4;
		this.backwardSpeed = (float)4;
		this.jumpSpeed = (float)16;
		this.inAirMultiplier = 0.25f;
		this.canJump = true;
	}

	public override void Start()
	{
		this.thisTransform = (Transform)this.GetComponent(typeof(Transform));
		this.character = (CharacterController)this.GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if (gameObject)
		{
			this.thisTransform.position = gameObject.transform.position;
		}
	}

	public override void OnEndGame()
	{
		this.moveTouchPad.Disable();
		this.jumpTouchPad.Disable();
		this.enabled = false;
	}

	public override void Update()
	{
		Vector3 vector = Vector3.zero;
		if (this.moveTouchPad.position.x > (float)0)
		{
			vector = Vector3.right * this.forwardSpeed * this.moveTouchPad.position.x;
		}
		else
		{
			vector = Vector3.right * this.backwardSpeed * this.moveTouchPad.position.x;
		}
		if (this.character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = this.jumpTouchPad;
			if (!joystick.IsFingerDown())
			{
				this.canJump = true;
			}
			if (this.canJump && joystick.IsFingerDown())
			{
				flag = true;
				this.canJump = false;
			}
			if (flag)
			{
				this.velocity = this.character.velocity;
				this.velocity.y = this.jumpSpeed;
			}
		}
		else
		{
			this.velocity.y = this.velocity.y + Physics.gravity.y * Time.deltaTime;
			vector.x *= this.inAirMultiplier;
		}
		vector += this.velocity;
		vector += Physics.gravity;
		vector *= Time.deltaTime;
		this.character.Move(vector);
		if (this.character.isGrounded)
		{
			this.velocity = Vector3.zero;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Slider_Behavior : MonoBehaviour
{
	public float slider_range;

	public Transform slider_touch;

	public string slider_name;

	public float slider_range_offset;

	public float count;

	private float center_offset;

	public override void Start()
	{
		this.center_offset = this.guiTexture.pixelInset.width / (float)2;
		if (this.slider_name == "Senstivity_P_R")
		{
			this.slider_range_offset = PlayerPrefs.GetFloat("Senstivity_Control");
			this.slider_range = (this.slider_range_offset - 0.005f) / 0.025f;
		}
		else if (this.slider_name == "Senstivity_Y")
		{
			this.slider_range_offset = PlayerPrefs.GetFloat("Senstivity_Control_Yaw");
			this.slider_range = (this.slider_range_offset - 0.01f) / 0.09f;
		}
		else if (this.slider_name == "A_Stable")
		{
			this.slider_range_offset = PlayerPrefs.GetFloat("Auto_Stabilize");
			this.slider_range = this.slider_range_offset / 0.0005f;
		}
		else if (this.slider_name == "Thrust")
		{
			this.slider_range_offset = PlayerPrefs.GetFloat("Thrust_Multiplier");
			this.slider_range = this.slider_range_offset / 0.5f;
		}
		else if (this.slider_name == "Weight")
		{
			this.slider_range_offset = PlayerPrefs.GetFloat("Mass_Multiplier");
			this.slider_range = this.slider_range_offset / 0.2f;
		}
		this.count = (float)0;
	}

	public override void Update()
	{
		if (this.count == (float)0)
		{
			float x = (float)380 * this.slider_range - this.center_offset + this.slider_touch.guiTexture.pixelInset.x + (float)20;
			Rect pixelInset = this.guiTexture.pixelInset;
			float num = pixelInset.x = x;
			Rect rect = this.guiTexture.pixelInset = pixelInset;
			this.count += (float)1;
		}
		this.slider_range = (this.guiTexture.pixelInset.x + this.center_offset - this.slider_touch.guiTexture.pixelInset.x - (float)20) / (float)380;
		if (this.slider_name == "Senstivity_P_R")
		{
			this.slider_range_offset = this.slider_range * 0.025f + 0.005f;
		}
		if (this.slider_name == "Senstivity_Y")
		{
			this.slider_range_offset = this.slider_range * 0.09f + 0.01f;
		}
		if (this.slider_name == "A_Stable")
		{
			this.slider_range_offset = this.slider_range * 0.0005f;
		}
		if (this.slider_name == "Thrust")
		{
			this.slider_range_offset = this.slider_range * 0.5f;
		}
		if (this.slider_name == "Weight")
		{
			this.slider_range_offset = this.slider_range * 0.2f;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Slider_New_GUI : MonoBehaviour
{
	public float slider_SPR;

	public float slider_SY;

	public float slider_Auto_S;

	public float slider_Thrus_M;

	public float slider_Thrus_DZ_M;

	public float slider_Mass_M;

	public float aero_Drag;

	public float slider_max_TA;

	public float roll_pitch_P;

	public float roll_pitch_I;

	public float roll_pitch_D;

	public float yaw_P;

	public float yaw_I;

	public float yaw_D;

	public Transform[] quads;

	public int quad_selected;

	public Transform Quad_cam;

	public Transform Controller_cam;

	public Transform Controller_L;

	public Transform Controller_R;

	public Transform controller_map;

	public Transform slider_T_CS_PR;

	public Transform slider_T_CS_Y;

	public Transform slider_T_AS;

	public Transform slider_T_MCT;

	public Transform slider_T_DZT;

	public Transform slider_T_TW;

	public Transform slider_T_AD;

	public Transform slider_Wind_D;

	public Transform slider_Wind_S;

	public Transform slider_T_FPV_Tilt_angle;

	public Transform slider_T_max_TA;

	public Transform normal_mode_T;

	public Transform sports_mode_T;

	public Transform Acro_mode_T;

	public Transform D3D_mode_T;

	public Transform lights_flip_T;

	public int flying_mode;

	public Transform slider_T_Roll_Pitch_P;

	public Transform slider_T_Roll_Pitch_I;

	public Transform slider_T_Roll_Pitch_D;

	public Transform slider_T_Yaw_P;

	public Transform slider_T_Yaw_I;

	public Transform slider_T_Yaw_D;

	public Transform text_adv_set;

	public Transform text_units;

	public Transform text_camera;

	public Transform text_inputmode;

	public Transform text_wind_direction;

	public Transform text_tilt_angle;

	public Transform slider_Text_MCT;

	public Transform slider_Text_DZT;

	public Transform slider_Text_TW;

	public Transform slider_text_FPV_Tilt_angle;

	public Transform PID_button;

	public Transform button_adv_set;

	public Transform challenges_toggle;

	public Transform Attitude_toggle;

	public Transform gusty_wind;

	public int page_display;

	public Transform VR_enable_T;

	public Transform VR_camera;

	public Transform Canvas_T;

	public Transform canvas_events;

	public Transform VR_enable_T_text;

	public Transform page_1;

	public Transform page_2;

	public Transform page_3;

	public Transform page_4;

	public Transform page_text;

	public Transform ctrl_toggle;

	public Transform help_button;

	public Transform VR_purchase_button;

	public Transform VR_toggle_text;

	public Transform VR_disable_button;

	public bool VR_Confirm;

	public Transform VR_Confirm_T;

	public Transform VR_Confirm_Text;

	public bool VR_Confirm_time_Once;

	public float VR_Confirm_time_start;

	private bool lights_flip_toggle;

	private bool units_switch;

	private string units_standard;

	private string units_distance;

	private string units_velocity;

	private string units_Force;

	private string units_Weight;

	private float units_distance_m;

	private float units_velocity_m;

	private float units_Force_m;

	private float units_Weight_m;

	private string challenge_button;

	private bool challenge_button_m;

	private int camera_change;

	private string[] camera_selected;

	private bool att_indicator_m;

	private string att_indicator;

	private string adv_set_enabled;

	private int sl_w;

	private int sl_h;

	private int sl_off_h;

	private int bt_w;

	private int bts_w;

	private int input_mode_change;

	private string[] input_mode;

	private Rect windowRect;

	private Rect windowRect2;

	private bool toggle_win;

	private bool toggle_win2;

	private float slider_wind_magnitude;

	private int slider_wind_direction;

	private bool wind_condition;

	private int wind_condition_int;

	private int slider_FPV_Tilt_angle;

	private bool VR_enabled;

	private int VR_enabled_int;

	private bool controller_status;

	private int controller_status_int;

	private int controller_l_h_int;

	private int controller_l_v_int;

	private int controller_r_h_int;

	private int controller_r_v_int;

	private int controller_l_h_i_int;

	private int controller_l_v_i_int;

	private int controller_r_h_i_int;

	private int controller_r_v_i_int;

	private float[] Axis_;

	public Slider_New_GUI()
	{
		this.quads = new Transform[3];
		this.units_standard = "Imperial";
		this.units_distance = "Feet";
		this.units_velocity = "Mph";
		this.units_Force = "lbf";
		this.units_Weight = "lb";
		this.units_distance_m = 3.2808f;
		this.units_velocity_m = 3.6f;
		this.units_Force_m = 2.2046f;
		this.units_Weight_m = 2.2046f;
		this.challenge_button = "On";
		this.challenge_button_m = true;
		this.camera_selected = new string[]
		{
			"Eye Level",
			"FPV 1",
			"Gimbal",
			"Follow",
			"FPV 2"
		};
		this.att_indicator_m = true;
		this.att_indicator = "on";
		this.input_mode = new string[]
		{
			"Mode 2",
			"Mode 1",
			string.Empty,
			"Mode 3",
			"Mode 4",
			"Accelerometer"
		};
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		this.Axis_ = new float[21];
	}

	public override void Start()
	{
		if (!SystemInfo.supportsGyroscope)
		{
			((Toggle)this.VR_enable_T.gameObject.GetComponent(typeof(Toggle))).interactable = false;
			((Text)this.VR_enable_T_text.gameObject.GetComponent(typeof(Text))).text = "Cannot enable VR as Gyroscope is not detected on this device";
			this.VR_purchase_button.gameObject.SetActive(false);
		}
		else if (PlayerPrefs.GetInt("Enable_VR_purchased") != 1)
		{
			((Text)this.VR_enable_T_text.gameObject.GetComponent(typeof(Text))).text = "Make sure a controller is attached and enabled. To interact just gaze at the UI and Press the Cardboard trigger. Quad will reset evey 90 secs. in trial mode";
			((Text)this.VR_toggle_text.gameObject.GetComponent(typeof(Text))).text = "VR Cardboard Trial";
			this.VR_purchase_button.gameObject.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("Enable_VR_purchased") == 1)
		{
			((Text)this.VR_enable_T_text.gameObject.GetComponent(typeof(Text))).text = "Make sure a controller is attached and enabled. To interact just gaze at the UI and Press the Cardboard trigger.";
			((Text)this.VR_toggle_text.gameObject.GetComponent(typeof(Text))).text = "VR Cardboard";
			this.VR_purchase_button.gameObject.SetActive(false);
		}
		this.load_values();
		this.quads[0].GetComponent<Renderer>().enabled = false;
		this.quads[1].GetComponent<Renderer>().enabled = false;
		this.quads[2].GetComponent<Renderer>().enabled = false;
		this.quads[this.quad_selected].GetComponent<Renderer>().enabled = true;
		if (this.VR_enabled)
		{
			this.VR_Confirm = true;
		}
	}

	public override void Update()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			if (!this.VR_Confirm_time_Once)
			{
				this.VR_Confirm_T.gameObject.SetActive(true);
				this.VR_Confirm_time_start = Time.time;
			}
			this.VR_Confirm_time_Once = true;
			((Text)this.VR_Confirm_Text.gameObject.GetComponent(typeof(Text))).text = "Disabling in " + (this.VR_Confirm_time_start + (float)15 - Time.time).ToString("f0") + " secs";
			if (Time.time > this.VR_Confirm_time_start + (float)15)
			{
				this.VR_Controller_Disable();
				this.VR_Confirm_T.gameObject.SetActive(false);
			}
		}
		else
		{
			this.VR_Confirm_time_Once = false;
		}
		if (this.VR_enabled && this.VR_Confirm)
		{
			this.VR_disable_button.gameObject.SetActive(true);
			this.VR_Confirm_T.gameObject.SetActive(false);
		}
		((Text)this.slider_Text_MCT.gameObject.GetComponent(typeof(Text))).text = "Max. Combined Thrust " + (this.slider_Thrus_M * this.units_Force_m * (float)2 * (float)4).ToString("f2") + " " + this.units_Force;
		((Text)this.slider_Text_DZT.gameObject.GetComponent(typeof(Text))).text = "Zero Thrust at " + (this.slider_Thrus_DZ_M * this.units_velocity_m).ToString("f2") + " " + this.units_velocity;
		((Text)this.slider_Text_TW.gameObject.GetComponent(typeof(Text))).text = "Total Weight " + (this.slider_Mass_M * 9.8f * this.units_Weight_m).ToString("f2") + " " + this.units_Weight;
		((Text)this.slider_text_FPV_Tilt_angle.gameObject.GetComponent(typeof(Text))).text = "FPV Tilt Angle  " + this.slider_FPV_Tilt_angle.ToString() + " Deg";
		((Text)this.text_units.gameObject.GetComponent(typeof(Text))).text = this.units_standard;
		((Text)this.text_camera.gameObject.GetComponent(typeof(Text))).text = this.camera_selected[this.camera_change];
		((Text)this.text_inputmode.gameObject.GetComponent(typeof(Text))).text = this.input_mode[this.input_mode_change];
		((Text)this.text_wind_direction.gameObject.GetComponent(typeof(Text))).text = "Wind Direction: " + this.slider_wind_direction;
		((Text)this.text_tilt_angle.gameObject.GetComponent(typeof(Text))).text = "Maximum Tilt Angle: " + this.slider_max_TA;
		if (this.att_indicator_m)
		{
			this.att_indicator = "On";
		}
		else
		{
			this.att_indicator = "Off";
		}
		if (this.challenge_button_m)
		{
			this.challenge_button = "On";
		}
		else
		{
			this.challenge_button = "Off";
		}
		if (this.VR_enabled)
		{
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.help_button.gameObject.SetActive(false);
			this.Quad_cam.gameObject.SetActive(false);
			this.Controller_cam.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.help_button.gameObject.SetActive(true);
			this.VR_Confirm = false;
			this.VR_disable_button.gameObject.SetActive(false);
			this.VR_Confirm_T.gameObject.SetActive(false);
			this.Quad_cam.gameObject.SetActive(true);
			this.Controller_cam.gameObject.SetActive(true);
			this.VR_Confirm = false;
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (this.VR_enabled)
			{
				this.VR_Controller_Disable();
			}
			else
			{
				this.Fly();
			}
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			this.VR_Controller(false);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.VR_Controller(true);
		}
		this.page_change();
		if (this.units_switch)
		{
			this.units_standard = "Metric";
			this.units_distance = "Meters";
			this.units_velocity = "Kmph";
			this.units_Force = "Kgf";
			this.units_Weight = "Kg";
			this.units_distance_m = (float)1;
			this.units_velocity_m = 3.6f;
			this.units_Force_m = (float)1;
			this.units_Weight_m = (float)1;
		}
		else
		{
			this.units_standard = "Imperial";
			this.units_distance = "Feet";
			this.units_velocity = "Mph";
			this.units_Force = "lbf";
			this.units_Weight = "lb";
			this.units_distance_m = 3.2808f;
			this.units_velocity_m = 2.2369f;
			this.units_Force_m = 2.2046f;
			this.units_Weight_m = 2.2046f;
		}
		if (this.flying_mode == 0)
		{
			this.slider_T_AS.gameObject.SetActive(false);
			this.slider_T_max_TA.gameObject.SetActive(true);
			((Slider)this.slider_T_Yaw_D.GetComponent(typeof(Slider))).interactable = true;
			this.slider_T_Roll_Pitch_I.gameObject.SetActive(true);
		}
		else if (this.flying_mode == 2 || this.flying_mode == 3)
		{
			this.slider_T_AS.gameObject.SetActive(true);
			this.slider_T_max_TA.gameObject.SetActive(false);
			((Slider)this.slider_T_Yaw_D.GetComponent(typeof(Slider))).interactable = true;
			((Slider)this.slider_T_AS.GetComponent(typeof(Slider))).interactable = false;
			this.slider_T_Roll_Pitch_I.gameObject.SetActive(false);
		}
		else
		{
			this.slider_T_AS.gameObject.SetActive(true);
			this.slider_T_max_TA.gameObject.SetActive(false);
			((Slider)this.slider_T_AS.GetComponent(typeof(Slider))).interactable = true;
			((Slider)this.slider_T_Yaw_D.GetComponent(typeof(Slider))).interactable = true;
			this.slider_T_Roll_Pitch_I.gameObject.SetActive(false);
		}
		this.Axis_[1] = Input.GetAxis("Horizontal");
		this.Axis_[2] = Input.GetAxis("Vertical");
		this.Axis_[3] = Input.GetAxis("Third_Axis");
		this.Axis_[4] = Input.GetAxis("Fourth_Axis");
		this.Axis_[5] = Input.GetAxis("Fifth_Axis");
		this.Axis_[6] = Input.GetAxis("Sixth_Axis");
		this.Axis_[7] = Input.GetAxis("Seventh_Axis");
		this.Axis_[8] = Input.GetAxis("Eighth_Axis");
		this.Axis_[9] = Input.GetAxis("Ninth_Axis");
		this.Axis_[10] = Input.GetAxis("Tenth_Axis");
		this.Axis_[11] = Input.GetAxis("Eleventh_Axis");
		this.Axis_[12] = Input.GetAxis("Twelveth_Axis");
		this.Axis_[13] = Input.GetAxis("Thirteenth_Axis");
		this.Axis_[14] = Input.GetAxis("Fourteenth_Axis");
		this.Axis_[15] = Input.GetAxis("Fifteenth_Axis");
		this.Axis_[16] = Input.GetAxis("Sixteenth_Axis");
		this.Axis_[17] = Input.GetAxis("Seventeenth_Axis");
		this.Axis_[18] = Input.GetAxis("Eighteenth_Axis");
		this.Axis_[19] = Input.GetAxis("Nineteenth_Axis");
		this.Axis_[20] = Input.GetAxis("Twentyth_Axis");
		if (this.controller_status)
		{
			this.controller_map.gameObject.SetActive(true);
			float x = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int * 0.25f;
			Vector3 localPosition = this.Controller_L.localPosition;
			float num = localPosition.x = x;
			Vector3 vector = this.Controller_L.localPosition = localPosition;
			float z = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int * 0.25f;
			Vector3 localPosition2 = this.Controller_L.localPosition;
			float num2 = localPosition2.z = z;
			Vector3 vector2 = this.Controller_L.localPosition = localPosition2;
			float x2 = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int * 0.25f;
			Vector3 localPosition3 = this.Controller_R.localPosition;
			float num3 = localPosition3.x = x2;
			Vector3 vector3 = this.Controller_R.localPosition = localPosition3;
			float z2 = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int * 0.25f;
			Vector3 localPosition4 = this.Controller_R.localPosition;
			float num4 = localPosition4.z = z2;
			Vector3 vector4 = this.Controller_R.localPosition = localPosition4;
		}
		else
		{
			this.controller_map.gameObject.SetActive(false);
		}
		for (int i = 0; i < 3; i++)
		{
			if (this.lights_flip_toggle)
			{
				int num5 = 0;
				Color color = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num6 = color.r = (float)num5;
				Color color2 = this.quads[i].GetComponent<Renderer>().materials[4].color = color;
				int num7 = 1;
				Color color3 = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num8 = color3.g = (float)num7;
				Color color4 = this.quads[i].GetComponent<Renderer>().materials[4].color = color3;
				int num9 = 0;
				Color color5 = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num10 = color5.b = (float)num9;
				Color color6 = this.quads[i].GetComponent<Renderer>().materials[4].color = color5;
				int num11 = 1;
				Color color7 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num12 = color7.r = (float)num11;
				Color color8 = this.quads[i].GetComponent<Renderer>().materials[3].color = color7;
				int num13 = 0;
				Color color9 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num14 = color9.g = (float)num13;
				Color color10 = this.quads[i].GetComponent<Renderer>().materials[3].color = color9;
				int num15 = 0;
				Color color11 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num16 = color11.b = (float)num15;
				Color color12 = this.quads[i].GetComponent<Renderer>().materials[3].color = color11;
			}
			else
			{
				int num17 = 1;
				Color color13 = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num18 = color13.r = (float)num17;
				Color color14 = this.quads[i].GetComponent<Renderer>().materials[4].color = color13;
				int num19 = 0;
				Color color15 = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num20 = color15.g = (float)num19;
				Color color16 = this.quads[i].GetComponent<Renderer>().materials[4].color = color15;
				int num21 = 0;
				Color color17 = this.quads[i].GetComponent<Renderer>().materials[4].color;
				float num22 = color17.b = (float)num21;
				Color color18 = this.quads[i].GetComponent<Renderer>().materials[4].color = color17;
				int num23 = 0;
				Color color19 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num24 = color19.r = (float)num23;
				Color color20 = this.quads[i].GetComponent<Renderer>().materials[3].color = color19;
				int num25 = 1;
				Color color21 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num26 = color21.g = (float)num25;
				Color color22 = this.quads[i].GetComponent<Renderer>().materials[3].color = color21;
				int num27 = 0;
				Color color23 = this.quads[i].GetComponent<Renderer>().materials[3].color;
				float num28 = color23.b = (float)num27;
				Color color24 = this.quads[i].GetComponent<Renderer>().materials[3].color = color23;
			}
		}
		((Slider)this.slider_T_CS_Y.gameObject.GetComponent(typeof(Slider))).value = this.slider_SY;
		((Slider)this.slider_T_Yaw_P.gameObject.GetComponent(typeof(Slider))).value = this.yaw_P;
		((Slider)this.slider_T_CS_PR.gameObject.GetComponent(typeof(Slider))).value = this.slider_SPR;
		((Slider)this.slider_T_Roll_Pitch_P.gameObject.GetComponent(typeof(Slider))).value = this.roll_pitch_P;
		((Slider)this.slider_T_FPV_Tilt_angle.gameObject.GetComponent(typeof(Slider))).value = (float)this.slider_FPV_Tilt_angle;
		if (this.flying_mode == 0)
		{
			((Toggle)this.normal_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = true;
			((Toggle)this.sports_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.Acro_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.D3D_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
		}
		else if (this.flying_mode == 1)
		{
			((Toggle)this.normal_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.sports_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = true;
			((Toggle)this.Acro_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.D3D_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
		}
		else if (this.flying_mode == 2)
		{
			((Toggle)this.normal_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.sports_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.Acro_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = true;
			((Toggle)this.D3D_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
		}
		else if (this.flying_mode == 3)
		{
			((Toggle)this.normal_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.sports_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.Acro_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
			((Toggle)this.D3D_mode_T.gameObject.GetComponent(typeof(Toggle))).isOn = true;
		}
	}

	public override void load_values()
	{
		this.slider_SPR = PlayerPrefs.GetFloat("Senstivity_Control");
		this.slider_SY = PlayerPrefs.GetFloat("Senstivity_Control_Yaw");
		this.slider_max_TA = PlayerPrefs.GetFloat("Max_Tilt_Angle");
		this.roll_pitch_P = PlayerPrefs.GetFloat("Pitch_Roll_P");
		this.roll_pitch_I = PlayerPrefs.GetFloat("Pitch_Roll_I");
		this.roll_pitch_D = PlayerPrefs.GetFloat("Pitch_Roll_D");
		this.flying_mode = PlayerPrefs.GetInt("Flying_Mode");
		if (PlayerPrefs.GetInt("Lights_Flip") == 1)
		{
			this.lights_flip_toggle = true;
		}
		else
		{
			this.lights_flip_toggle = false;
		}
		this.yaw_P = PlayerPrefs.GetFloat("Yaw_P");
		this.yaw_I = PlayerPrefs.GetFloat("Yaw_I");
		this.yaw_D = PlayerPrefs.GetFloat("Yaw_D");
		this.slider_FPV_Tilt_angle = PlayerPrefs.GetInt("Camera_FPV_Tilt");
		this.slider_Auto_S = PlayerPrefs.GetFloat("Auto_Stabilize");
		this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier");
		this.slider_Thrus_DZ_M = PlayerPrefs.GetFloat("Thrust_Dynamic");
		this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier");
		this.units_standard = PlayerPrefs.GetString("Units");
		this.camera_change = PlayerPrefs.GetInt("Camera");
		this.att_indicator = PlayerPrefs.GetString("Attitude_Indicator");
		this.adv_set_enabled = PlayerPrefs.GetString("Inventory");
		this.quad_selected = PlayerPrefs.GetInt("Quad");
		this.input_mode_change = PlayerPrefs.GetInt("Input_mode");
		this.challenge_button = PlayerPrefs.GetString("Challenge_Button");
		this.aero_Drag = PlayerPrefs.GetFloat("Aerodynamic_Drag");
		this.VR_enabled_int = PlayerPrefs.GetInt("Camera_VR");
		if (this.VR_enabled_int == 0)
		{
			this.VR_enabled = false;
		}
		if (this.VR_enabled_int == 1)
		{
			this.VR_enabled = true;
		}
		if (this.quad_selected == 0)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q0");
			this.slider_Thrus_DZ_M = PlayerPrefs.GetFloat("Thrust_Dynamic_Q0");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q0");
		}
		if (this.quad_selected == 1)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q1");
			this.slider_Thrus_DZ_M = PlayerPrefs.GetFloat("Thrust_Dynamic_Q1");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q1");
		}
		if (this.quad_selected == 2)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q2");
			this.slider_Thrus_DZ_M = PlayerPrefs.GetFloat("Thrust_Dynamic_Q2");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q2");
		}
		if (this.att_indicator == "On")
		{
			this.att_indicator_m = true;
		}
		if (this.att_indicator == "Off")
		{
			this.att_indicator_m = false;
		}
		if (this.challenge_button == "On")
		{
			this.challenge_button_m = true;
		}
		if (this.challenge_button == "Off")
		{
			this.challenge_button_m = false;
		}
		if (this.units_standard == "Metric")
		{
			this.units_switch = true;
		}
		else
		{
			this.units_switch = false;
		}
		this.slider_wind_magnitude = PlayerPrefs.GetFloat("Wind_Magnitude");
		this.slider_wind_direction = PlayerPrefs.GetInt("Wind_Direction");
		this.wind_condition_int = PlayerPrefs.GetInt("Wind_Condition");
		if (this.wind_condition_int == 0)
		{
			this.wind_condition = false;
		}
		if (this.wind_condition_int == 1)
		{
			this.wind_condition = true;
		}
		this.controller_status_int = PlayerPrefs.GetInt("Controller_Status");
		if (this.controller_status_int == 0)
		{
			this.controller_status = false;
		}
		if (this.controller_status_int == 1)
		{
			this.controller_status = true;
		}
		this.controller_l_h_int = PlayerPrefs.GetInt("Left_Horizontal_Joy");
		this.controller_l_v_int = PlayerPrefs.GetInt("Left_Vertical_Joy");
		this.controller_r_h_int = PlayerPrefs.GetInt("Right_Horizontal_Joy");
		this.controller_r_v_int = PlayerPrefs.GetInt("Right_Vertical_Joy");
		this.controller_l_h_i_int = PlayerPrefs.GetInt("Left_Horizontal_Joy_Inv");
		this.controller_l_v_i_int = PlayerPrefs.GetInt("Left_Vertical_Joy_Inv");
		this.controller_r_h_i_int = PlayerPrefs.GetInt("Right_Horizontal_Joy_Inv");
		this.controller_r_v_i_int = PlayerPrefs.GetInt("Right_Vertical_Joy_Inv");
		((Slider)this.slider_T_CS_PR.gameObject.GetComponent(typeof(Slider))).value = this.slider_SPR;
		((Slider)this.slider_T_CS_Y.gameObject.GetComponent(typeof(Slider))).value = this.slider_SY;
		((Slider)this.slider_T_AS.gameObject.GetComponent(typeof(Slider))).value = this.slider_Auto_S;
		((Slider)this.slider_T_max_TA.gameObject.GetComponent(typeof(Slider))).value = this.slider_max_TA;
		((Slider)this.slider_T_MCT.gameObject.GetComponent(typeof(Slider))).value = this.slider_Thrus_M;
		((Slider)this.slider_T_DZT.gameObject.GetComponent(typeof(Slider))).value = this.slider_Thrus_DZ_M;
		((Slider)this.slider_T_TW.gameObject.GetComponent(typeof(Slider))).value = this.slider_Mass_M;
		((Slider)this.slider_T_AD.gameObject.GetComponent(typeof(Slider))).value = this.aero_Drag;
		((Slider)this.slider_Wind_D.gameObject.GetComponent(typeof(Slider))).value = (float)this.slider_wind_direction;
		((Slider)this.slider_Wind_S.gameObject.GetComponent(typeof(Slider))).value = this.slider_wind_magnitude;
		((Slider)this.slider_T_FPV_Tilt_angle.gameObject.GetComponent(typeof(Slider))).value = (float)this.slider_FPV_Tilt_angle;
		((Slider)this.slider_T_Roll_Pitch_P.gameObject.GetComponent(typeof(Slider))).value = this.roll_pitch_P;
		((Slider)this.slider_T_Roll_Pitch_I.gameObject.GetComponent(typeof(Slider))).value = this.roll_pitch_I;
		((Slider)this.slider_T_Roll_Pitch_D.gameObject.GetComponent(typeof(Slider))).value = this.roll_pitch_D;
		((Slider)this.slider_T_Yaw_P.gameObject.GetComponent(typeof(Slider))).value = this.yaw_P;
		((Slider)this.slider_T_Yaw_I.gameObject.GetComponent(typeof(Slider))).value = this.yaw_I;
		((Slider)this.slider_T_Yaw_D.gameObject.GetComponent(typeof(Slider))).value = this.yaw_D;
		((Toggle)this.challenges_toggle.gameObject.GetComponent(typeof(Toggle))).isOn = this.challenge_button_m;
		((Toggle)this.Attitude_toggle.gameObject.GetComponent(typeof(Toggle))).isOn = this.att_indicator_m;
		((Toggle)this.ctrl_toggle.gameObject.GetComponent(typeof(Toggle))).isOn = this.controller_status;
		((Toggle)this.gusty_wind.gameObject.GetComponent(typeof(Toggle))).isOn = this.wind_condition;
		((Toggle)this.VR_enable_T.gameObject.GetComponent(typeof(Toggle))).isOn = this.VR_enabled;
		((Toggle)this.lights_flip_T.gameObject.GetComponent(typeof(Toggle))).isOn = this.lights_flip_toggle;
		if (this.adv_set_enabled == "Subscribed" || this.adv_set_enabled == "Purchase Success")
		{
			((Slider)this.slider_T_MCT.gameObject.GetComponent(typeof(Slider))).interactable = true;
			((Slider)this.slider_T_DZT.gameObject.GetComponent(typeof(Slider))).interactable = true;
			((Slider)this.slider_T_TW.gameObject.GetComponent(typeof(Slider))).interactable = true;
			((Slider)this.slider_T_AD.gameObject.GetComponent(typeof(Slider))).interactable = true;
			((Button)this.PID_button.gameObject.GetComponent(typeof(Button))).interactable = true;
			this.text_adv_set.gameObject.SetActive(true);
			this.button_adv_set.gameObject.SetActive(false);
		}
		else
		{
			((Slider)this.slider_T_MCT.gameObject.GetComponent(typeof(Slider))).interactable = false;
			((Slider)this.slider_T_DZT.gameObject.GetComponent(typeof(Slider))).interactable = false;
			((Slider)this.slider_T_TW.gameObject.GetComponent(typeof(Slider))).interactable = false;
			((Slider)this.slider_T_AD.gameObject.GetComponent(typeof(Slider))).interactable = false;
			((Button)this.PID_button.gameObject.GetComponent(typeof(Button))).interactable = false;
			this.text_adv_set.gameObject.SetActive(false);
			this.button_adv_set.gameObject.SetActive(true);
		}
	}

	public override void resetSliders()
	{
		PlayerPrefs.SetFloat("Senstivity_Control", 0.02f);
		PlayerPrefs.SetFloat("Senstivity_Control_Yaw", 0.05f);
		PlayerPrefs.SetFloat("Max_Tilt_Angle", (float)35);
		PlayerPrefs.SetFloat("Pitch_Roll_P", 0.0005f);
		PlayerPrefs.SetFloat("Pitch_Roll_I", (float)0);
		PlayerPrefs.SetFloat("Pitch_Roll_D", 0.0001f);
		PlayerPrefs.SetFloat("Yaw_P", 0.05f);
		PlayerPrefs.SetFloat("Yaw_I", (float)0);
		PlayerPrefs.SetFloat("Yaw_D", 0.02f);
		PlayerPrefs.SetInt("Flying_Mode", 0);
		PlayerPrefs.SetInt("Lights_Flip", 0);
		PlayerPrefs.SetInt("Camera_FPV_Tilt", 0);
		PlayerPrefs.SetFloat("Auto_Stabilize", 0.0005f);
		PlayerPrefs.SetFloat("Thrust_Multiplier", 0.1f);
		PlayerPrefs.SetFloat("Thrust_Dynamic", 35.7632f);
		PlayerPrefs.SetFloat("Mass_Multiplier", 0.04f);
		PlayerPrefs.SetString("Units", "Imperial");
		PlayerPrefs.SetInt("Camera", 0);
		PlayerPrefs.SetString("Attitude_Indicator", "On");
		PlayerPrefs.SetString("Challenge_Button", "On");
		PlayerPrefs.SetInt("Input_mode", 0);
		PlayerPrefs.SetFloat("Aerodynamic_Drag", 0.2f);
		if (this.quad_selected == 0)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", 0.1f);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q0", 35.7632f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q0", 0.04f);
		}
		if (this.quad_selected == 1)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", 0.09f);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q1", 35.7632f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q1", 0.05f);
		}
		if (this.quad_selected == 2)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", 0.14f);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q2", 35.7632f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q2", 0.08f);
		}
		PlayerPrefs.SetInt("Challenge_selected", 0);
		PlayerPrefs.SetFloat("Wind_Magnitude", (float)0);
		PlayerPrefs.SetInt("Wind_Direction", 0);
		PlayerPrefs.SetInt("Wind_Condition", 0);
		PlayerPrefs.SetInt("Controller_Status", 0);
		PlayerPrefs.SetInt("Camera_VR", 0);
		this.load_values();
	}

	public override void saveSliders()
	{
		PlayerPrefs.SetFloat("Senstivity_Control", this.slider_SPR);
		PlayerPrefs.SetFloat("Senstivity_Control_Yaw", this.slider_SY);
		PlayerPrefs.SetFloat("Max_Tilt_Angle", this.slider_max_TA);
		PlayerPrefs.SetFloat("Pitch_Roll_P", this.roll_pitch_P);
		PlayerPrefs.SetFloat("Pitch_Roll_I", this.roll_pitch_I);
		PlayerPrefs.SetFloat("Pitch_Roll_D", this.roll_pitch_D);
		PlayerPrefs.SetFloat("Yaw_P", this.yaw_P);
		PlayerPrefs.SetFloat("Yaw_I", this.yaw_I);
		PlayerPrefs.SetFloat("Yaw_D", this.yaw_D);
		PlayerPrefs.SetInt("Flying_Mode", this.flying_mode);
		if (this.lights_flip_toggle)
		{
			PlayerPrefs.SetInt("Lights_Flip", 1);
		}
		else
		{
			PlayerPrefs.SetInt("Lights_Flip", 0);
		}
		PlayerPrefs.SetFloat("Auto_Stabilize", this.slider_Auto_S);
		PlayerPrefs.SetFloat("Thrust_Multiplier", this.slider_Thrus_M);
		PlayerPrefs.SetFloat("Thrust_Dynamic", this.slider_Thrus_DZ_M);
		PlayerPrefs.SetFloat("Mass_Multiplier", this.slider_Mass_M);
		PlayerPrefs.SetString("Units", this.units_standard);
		PlayerPrefs.SetInt("Camera", this.camera_change);
		PlayerPrefs.SetString("Attitude_Indicator", this.att_indicator);
		PlayerPrefs.SetInt("Quad", this.quad_selected);
		PlayerPrefs.SetInt("Input_mode", this.input_mode_change);
		PlayerPrefs.SetString("Challenge_Button", this.challenge_button);
		PlayerPrefs.SetFloat("Aerodynamic_Drag", this.aero_Drag);
		if (this.VR_Confirm)
		{
			this.VR_enabled_int = 1;
		}
		if (!this.VR_Confirm)
		{
			this.VR_enabled_int = 0;
		}
		PlayerPrefs.SetInt("Camera_VR", this.VR_enabled_int);
		if (this.quad_selected == 0)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q0", this.slider_Thrus_DZ_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q0", this.slider_Mass_M);
		}
		if (this.quad_selected == 1)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q1", this.slider_Thrus_DZ_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q1", this.slider_Mass_M);
		}
		if (this.quad_selected == 2)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Thrust_Dynamic_Q2", this.slider_Thrus_DZ_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q2", this.slider_Mass_M);
		}
		if (this.challenge_button == "Off")
		{
			PlayerPrefs.SetInt("Challenge_selected", 0);
		}
		PlayerPrefs.SetFloat("Wind_Magnitude", this.slider_wind_magnitude);
		PlayerPrefs.SetInt("Wind_Direction", this.slider_wind_direction);
		PlayerPrefs.SetInt("Camera_FPV_Tilt", this.slider_FPV_Tilt_angle);
		if (this.wind_condition)
		{
			this.wind_condition_int = 1;
		}
		if (!this.wind_condition)
		{
			this.wind_condition_int = 0;
		}
		PlayerPrefs.SetInt("Wind_Condition", this.wind_condition_int);
		if (this.controller_status)
		{
			this.controller_status_int = 1;
		}
		if (!this.controller_status)
		{
			this.controller_status_int = 0;
		}
		PlayerPrefs.SetInt("Controller_Status", this.controller_status_int);
	}

	public override void Control_Senstivity_PR(float slider_PR)
	{
		this.slider_SPR = slider_PR;
		this.roll_pitch_P = slider_PR / 40f;
	}

	public override void Control_Senstivity_Y(float slider_Y)
	{
		this.slider_SY = slider_Y;
		this.yaw_P = slider_Y;
	}

	public override void Max_Tilt_Angle(float max_tilt_value)
	{
		this.slider_max_TA = max_tilt_value;
	}

	public override void Auto_Stability(float slider_AS)
	{
		this.slider_Auto_S = slider_AS;
	}

	public override void Total_Thrust(float slider_MCT)
	{
		this.slider_Thrus_M = slider_MCT;
	}

	public override void Dynamic_Thrust(float slider_DZT)
	{
		this.slider_Thrus_DZ_M = slider_DZT;
	}

	public override void Total_Weight(float slider_TW)
	{
		this.slider_Mass_M = slider_TW;
	}

	public override void Aer_Drag(float slider_AD)
	{
		this.aero_Drag = slider_AD;
	}

	public override void unit_change()
	{
		this.units_switch = !this.units_switch;
	}

	public override void cam_change()
	{
		this.camera_change++;
		if (this.camera_change >= 5)
		{
			this.camera_change = 0;
		}
	}

	public override void Attitude_Indicator(bool att_toggle)
	{
		this.att_indicator_m = att_toggle;
	}

	public override void Challenges_Button(bool chall_toggle)
	{
		this.challenge_button_m = chall_toggle;
	}

	public override void inputmode_change()
	{
		this.input_mode_change++;
		if (this.input_mode_change == 2)
		{
			this.input_mode_change = 3;
		}
		if (this.input_mode_change >= 6)
		{
			this.input_mode_change = 0;
		}
	}

	public override void UAV_Select()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel(3);
	}

	public override void Scene_Select()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel(7);
	}

	public override void Fly()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel(0);
	}

	public override void page_change_button()
	{
		this.page_display++;
		if (this.page_display > 1)
		{
			this.page_display = 0;
		}
	}

	public override void page_change()
	{
		if (this.page_display == 1)
		{
			float x = Mathf.Lerp(((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)-2500, Time.deltaTime * (float)10);
			Vector2 anchoredPosition = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num = anchoredPosition.x = x;
			Vector2 vector = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition;
			int num2 = 0;
			Vector2 anchoredPosition2 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num3 = anchoredPosition2.y = (float)num2;
			Vector2 vector2 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition2;
			float x2 = Mathf.Lerp(((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)0, Time.deltaTime * (float)10);
			Vector2 anchoredPosition3 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num4 = anchoredPosition3.x = x2;
			Vector2 vector3 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition3;
			int num5 = 1500;
			Vector2 anchoredPosition4 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num6 = anchoredPosition4.y = (float)num5;
			Vector2 vector4 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition4;
			int num7 = -1500;
			Vector2 anchoredPosition5 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num8 = anchoredPosition5.y = (float)num7;
			Vector2 vector5 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition5;
			((Text)this.page_text.gameObject.GetComponent(typeof(Text))).text = "Page 2 of 2";
		}
		if (this.page_display == 0)
		{
			float x3 = Mathf.Lerp(((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)0, Time.deltaTime * (float)10);
			Vector2 anchoredPosition6 = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num9 = anchoredPosition6.x = x3;
			Vector2 vector6 = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition6;
			int num10 = 0;
			Vector2 anchoredPosition7 = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num11 = anchoredPosition7.y = (float)num10;
			Vector2 vector7 = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition7;
			float x4 = Mathf.Lerp(((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition.x, (float)2500, Time.deltaTime * (float)10);
			Vector2 anchoredPosition8 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num12 = anchoredPosition8.x = x4;
			Vector2 vector8 = ((RectTransform)this.page_2.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition8;
			int num13 = 1500;
			Vector2 anchoredPosition9 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num14 = anchoredPosition9.y = (float)num13;
			Vector2 vector9 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition9;
			int num15 = -1500;
			Vector2 anchoredPosition10 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
			float num16 = anchoredPosition10.y = (float)num15;
			Vector2 vector10 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition10;
			this.Quad_cam.GetComponent<Camera>().enabled = true;
			this.Controller_cam.GetComponent<Camera>().enabled = false;
			((Text)this.page_text.gameObject.GetComponent(typeof(Text))).text = "Page 1 of 2";
		}
	}

	public override void controller_settings_page()
	{
		int num = 1500;
		Vector2 anchoredPosition = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
		float num2 = anchoredPosition.y = (float)num;
		Vector2 vector = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition;
		int num3 = 0;
		Vector2 anchoredPosition2 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
		float num4 = anchoredPosition2.y = (float)num3;
		Vector2 vector2 = ((RectTransform)this.page_3.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition2;
		this.Quad_cam.GetComponent<Camera>().enabled = false;
		this.Controller_cam.GetComponent<Camera>().enabled = true;
		this.page_display = 3;
	}

	public override void enable_controller(bool enable_controller_boo)
	{
		this.controller_status = enable_controller_boo;
	}

	public override void controller_mapping_button()
	{
		PlayerPrefs.SetInt("Controller_Status", 1);
		Application.LoadLevel(9);
	}

	public override void controller_page_back_button()
	{
		this.page_display = 0;
	}

	public override void PID_settings_page()
	{
		int num = -1500;
		Vector2 anchoredPosition = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
		float num2 = anchoredPosition.y = (float)num;
		Vector2 vector = ((RectTransform)this.page_1.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition;
		int num3 = 0;
		Vector2 anchoredPosition2 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition;
		float num4 = anchoredPosition2.y = (float)num3;
		Vector2 vector2 = ((RectTransform)this.page_4.gameObject.GetComponent(typeof(RectTransform))).anchoredPosition = anchoredPosition2;
		this.page_display = 4;
	}

	public override void PID_settings_back_page()
	{
		this.page_display = 0;
	}

	public override void Gusty_Wind(bool gusty_boo)
	{
		this.wind_condition = gusty_boo;
	}

	public override void Wind_direction(float Wind_Direction_Value)
	{
		this.slider_wind_direction = (int)Wind_Direction_Value;
	}

	public override void Wind_speed(float Wind_Speed_Value)
	{
		this.slider_wind_magnitude = Wind_Speed_Value;
	}

	public override void FPV_Tilt(float FPV_Tilt_Value)
	{
		this.slider_FPV_Tilt_angle = (int)FPV_Tilt_Value;
	}

	public override void slider_Pitch_Roll_P(float P_R_P_Value)
	{
		this.roll_pitch_P = P_R_P_Value;
		this.slider_SPR = P_R_P_Value * (float)40;
	}

	public override void slider_Pitch_Roll_I(float P_R_I_Value)
	{
		this.roll_pitch_I = P_R_I_Value;
	}

	public override void slider_Pitch_Roll_D(float P_R_D_Value)
	{
		this.roll_pitch_D = P_R_D_Value;
	}

	public override void slider_Yaw_P(float Yaw_P_Value)
	{
		this.yaw_P = Yaw_P_Value;
		this.slider_SY = Yaw_P_Value;
	}

	public override void slider_Yaw_I(float Yaw_I_Value)
	{
		this.yaw_I = Yaw_I_Value;
	}

	public override void slider_Yaw_D(float Yaw_D_Value)
	{
		this.yaw_D = Yaw_D_Value;
	}

	public override void Normal_Mode(bool normal_mode_switch)
	{
		if (normal_mode_switch)
		{
			this.flying_mode = 0;
		}
	}

	public override void Sports_Mode(bool sports_mode_switch)
	{
		if (sports_mode_switch)
		{
			this.flying_mode = 1;
		}
	}

	public override void Acro_Mode(bool acro_mode_switch)
	{
		if (acro_mode_switch)
		{
			this.flying_mode = 2;
		}
	}

	public override void D3D_Mode(bool d3d_mode_switch)
	{
		if (d3d_mode_switch)
		{
			this.flying_mode = 3;
		}
	}

	public override void Lights_Flip(bool lights_flip_switch)
	{
		this.lights_flip_toggle = lights_flip_switch;
	}

	public override void Buy_Advanced_Settings()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel(10);
	}

	public override void Buy_enable_VR()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel(10);
	}

	public override void VR_Controller(bool vr_enable_boo)
	{
		this.VR_enabled = vr_enable_boo;
	}

	public override void VR_Controller_Disable()
	{
		this.VR_Controller(false);
		((Toggle)this.VR_enable_T.gameObject.GetComponent(typeof(Toggle))).isOn = false;
	}

	public override void VR_Controller_Confirm()
	{
		this.VR_Confirm = true;
	}

	public override void facebook_button()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		Application.OpenURL("https://www.facebook.com/quadcopterfxsimulator");
	}

	public override void youtube_button()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		Application.OpenURL("https://www.youtube.com/watch?v=-6si8WkRtaY");
	}

	public override void Help_button()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		this.saveSliders();
		Application.LoadLevel("Help");
	}

	public override void QCFX_button()
	{
		if (this.VR_enabled && !this.VR_Confirm)
		{
			this.VR_Controller_Disable();
		}
		Application.OpenURL("http://quadcopterfx.3dcreativeworld.com/");
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Slider_position : MonoBehaviour
{
	public int line;

	public override void Start()
	{
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.x = x;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float y = (float)(Screen.height / 8 * this.line) - this.guiTexture.pixelInset.height / (float)2;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.y = y;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Slider_slide : MonoBehaviour
{
	public Transform slider_button;

	private float center_offset;

	public override void Start()
	{
		this.center_offset = this.slider_button.guiTexture.pixelInset.width / (float)2;
	}

	public override void Update()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && this.guiTexture.HitTest(Input.GetTouch(0).position))
		{
			float x = Mathf.Clamp(Input.GetTouch(0).position.x - this.center_offset, this.guiTexture.pixelInset.x + (float)20 - this.center_offset, this.guiTexture.pixelInset.x + this.guiTexture.pixelInset.width - (float)20 - this.center_offset);
			Rect pixelInset = this.slider_button.guiTexture.pixelInset;
			float num = pixelInset.x = x;
			Rect rect = this.slider_button.guiTexture.pixelInset = pixelInset;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Slider_SRP : MonoBehaviour
{
	public GUISkin customSkin_lowres;

	public GUISkin customSkin_medres;

	public GUISkin customSkin_highres;

	private GUISkin customSkin;

	public float slider_SPR;

	public float slider_SY;

	public float slider_Auto_S;

	public float slider_Thrus_M;

	public float slider_Mass_M;

	public float aero_Drag;

	public Transform[] quads;

	public int quad_selected;

	public Transform Quad_cam;

	public Transform Controller_cam;

	public Transform Controller_L;

	public Transform Controller_R;

	private bool units_switch;

	private string units_standard;

	private string units_distance;

	private string units_velocity;

	private string units_Force;

	private string units_Weight;

	private float units_distance_m;

	private float units_velocity_m;

	private float units_Force_m;

	private float units_Weight_m;

	private string challenge_button;

	private bool challenge_button_m;

	private int camera_change;

	private string[] camera_selected;

	private bool att_indicator_m;

	private string att_indicator;

	private string adv_set_enabled;

	private int sl_w;

	private int sl_h;

	private int sl_off_h;

	private int bt_w;

	private int bts_w;

	private int input_mode_change;

	private string[] input_mode;

	private Rect windowRect;

	private Rect windowRect2;

	private Rect windowRect3;

	private bool toggle_win;

	private bool toggle_win2;

	private float slider_wind_magnitude;

	private int slider_wind_direction;

	private bool wind_condition;

	private int wind_condition_int;

	private bool controller_status;

	private int controller_status_int;

	private int controller_l_h_int;

	private int controller_l_v_int;

	private int controller_r_h_int;

	private int controller_r_v_int;

	private int controller_l_h_i_int;

	private int controller_l_v_i_int;

	private int controller_r_h_i_int;

	private int controller_r_v_i_int;

	private float[] Axis_;

	public Slider_SRP()
	{
		this.quads = new Transform[3];
		this.units_standard = "Imperial";
		this.units_distance = "Feet";
		this.units_velocity = "Mph";
		this.units_Force = "lbf";
		this.units_Weight = "lb";
		this.units_distance_m = 3.2808f;
		this.units_velocity_m = 3.6f;
		this.units_Force_m = 2.2046f;
		this.units_Weight_m = 2.2046f;
		this.challenge_button = "On";
		this.challenge_button_m = true;
		this.camera_selected = new string[]
		{
			"Eye Level",
			"First Person View 1",
			"Gimbal",
			"Follow",
			"First Person View 2"
		};
		this.att_indicator_m = true;
		this.att_indicator = "on";
		this.input_mode = new string[]
		{
			"Mode 2",
			"Mode 1",
			string.Empty,
			"Mode 3",
			"Mode 4",
			"Accelerometer"
		};
		this.controller_l_h_i_int = 1;
		this.controller_l_v_i_int = 1;
		this.controller_r_h_i_int = 1;
		this.controller_r_v_i_int = 1;
		this.Axis_ = new float[11];
	}

	public override void Start()
	{
		this.load_values();
		this.windowRect = new Rect(((float)Screen.width - (float)Screen.width * 0.75f) * 0.5f, ((float)Screen.height - (float)Screen.height * 0.5f) * 0.5f, (float)Screen.width * 0.75f, (float)Screen.height * 0.5f);
		this.windowRect2 = new Rect(((float)Screen.width - (float)Screen.width * 0.8f) * 0.5f, ((float)Screen.height - (float)Screen.height * 0.8f) * 0.5f, (float)Screen.width * 0.8f, (float)Screen.height * 0.8f);
		this.windowRect3 = new Rect(((float)Screen.width - (float)Screen.width * 0.5f) * (float)0, (float)(Screen.height - Screen.height * 1) * 0.5f, (float)Screen.width * 0.75f, (float)(Screen.height * 1));
		if (Screen.height < 630)
		{
			this.sl_w = 400;
			this.sl_h = 35;
			this.sl_off_h = 50;
			this.bt_w = 121;
			this.bts_w = 200;
			this.customSkin = this.customSkin_lowres;
		}
		else if (Screen.height > 900)
		{
			this.sl_w = 600;
			this.sl_h = 60;
			this.sl_off_h = 100;
			this.bt_w = 190;
			this.bts_w = 270;
			this.customSkin = this.customSkin_highres;
		}
		else
		{
			this.sl_w = 500;
			this.sl_h = 45;
			this.sl_off_h = 75;
			this.bt_w = 130;
			this.bts_w = 240;
			this.customSkin = this.customSkin_medres;
		}
		this.quads[0].renderer.enabled = false;
		this.quads[1].renderer.enabled = false;
		this.quads[2].renderer.enabled = false;
		this.quads[this.quad_selected].renderer.enabled = true;
	}

	public override void Update()
	{
	}

	public override void OnGUI()
	{
		GUI.skin = this.customSkin;
		if (this.toggle_win)
		{
			this.windowRect = GUI.Window(0, this.windowRect, new GUI.WindowFunction(this.Advanced_Settings_Window), "Wind Settings");
		}
		else if (this.toggle_win2)
		{
			this.windowRect2 = GUI.Window(0, this.windowRect2, new GUI.WindowFunction(this.Controller_Settings_Window), "Controller Settings");
		}
		else
		{
			this.windowRect3 = GUI.Window(0, this.windowRect3, new GUI.WindowFunction(this.Disabled_Window), "Disabled");
			this.Quad_cam.camera.enabled = true;
			this.Controller_cam.camera.enabled = false;
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Control Senstivity (Pitch & Roll)");
			GUI.HorizontalSlider(new Rect((float)25, (float)this.sl_off_h, (float)this.sl_w, (float)this.sl_h), this.slider_SPR, 0.005f, 0.04f);
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 2 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Control Senstivity (Yaw)");
			GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 2), (float)this.sl_w, (float)this.sl_h), this.slider_SY, 0.01f, 0.1f);
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 3 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Auto Stabilize Senstivity");
			GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 3), (float)this.sl_w, (float)this.sl_h), this.slider_Auto_S, (float)0, 0.0005f);
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 4), (float)this.sl_w, (float)(this.sl_h - 10)), "ADVANCED SETTINGS");
			if (this.adv_set_enabled == "Subscribed" || this.adv_set_enabled == "Purchase Success")
			{
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 5 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Max. Combined Thrust " + (this.slider_Thrus_M * this.units_Force_m * (float)2 * (float)4).ToString("f2") + " " + this.units_Force);
				this.slider_Thrus_M = GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 5), (float)this.sl_w, (float)this.sl_h), this.slider_Thrus_M, 0.02f, 0.2f);
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 6 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Total Weight " + (this.slider_Mass_M * 9.8f * this.units_Weight_m).ToString("f2") + " " + this.units_Weight);
				this.slider_Mass_M = GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 6), (float)this.sl_w, (float)this.sl_h), this.slider_Mass_M, 0.01f, 0.15f);
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 7 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Aerodynamic Drag");
				this.aero_Drag = GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 7), (float)this.sl_w, (float)this.sl_h), this.aero_Drag, 0.05f, 0.6f);
			}
			else
			{
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 5), (float)this.sl_w, (float)(this.sl_h - 10)), "Max. Combined Thrust " + (this.slider_Thrus_M * this.units_Force_m * (float)2 * (float)4).ToString("f2") + " " + this.units_Force + " (Locked)");
				GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 6 - this.sl_off_h / 2), (float)this.sl_w, (float)this.sl_h), this.slider_Thrus_M, 0.02f, 0.2f);
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 6), (float)this.sl_w, (float)(this.sl_h - 10)), "Total Weight " + (this.slider_Mass_M * 9.8f * this.units_Weight_m).ToString("f2") + " " + this.units_Weight + " (Locked)");
				GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 7 - this.sl_off_h / 2), (float)this.sl_w, (float)this.sl_h), this.slider_Mass_M, 0.01f, 0.15f);
				GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 7), (float)this.sl_w, (float)(this.sl_h - 10)), "Aerodynamic Drag" + " (Locked)");
				GUI.HorizontalSlider(new Rect((float)25, (float)(this.sl_off_h * 8 - this.sl_off_h / 2), (float)this.sl_w, (float)this.sl_h), this.aero_Drag, 0.05f, 0.6f);
			}
			if (GUI.Button(new Rect((float)29, (float)(Screen.height - this.sl_off_h), (float)this.bt_w, (float)(this.sl_h - 10)), "Defaults"))
			{
			}
			if (GUI.Button(new Rect((float)(Screen.width / 2 - this.bt_w / 2 - this.bt_w), (float)(Screen.height - this.sl_off_h), (float)this.bt_w, (float)(this.sl_h - 10)), "Select Quad"))
			{
			}
			if (GUI.Button(new Rect((float)(Screen.width / 2 - this.bt_w / 2 + this.bt_w), (float)(Screen.height - this.sl_off_h), (float)this.bt_w, (float)(this.sl_h - 10)), "Select Scene"))
			{
			}
			if (GUI.Button(new Rect((float)(Screen.width - this.bt_w - 29), (float)(Screen.height - this.sl_off_h), (float)this.bt_w, (float)(this.sl_h - 10)), "Back") || Input.GetKeyDown(KeyCode.Escape))
			{
				this.saveSliders();
				Application.LoadLevel(0);
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Units:");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)this.sl_off_h, (float)this.bts_w, (float)(this.sl_h - 10)), this.units_standard))
			{
				this.units_switch = !this.units_switch;
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 2 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Camera:");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 2), (float)this.bts_w, (float)(this.sl_h - 10)), this.camera_selected[this.camera_change]))
			{
				this.camera_change++;
			}
			if (this.camera_change >= 5)
			{
				this.camera_change = 0;
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 3 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Attitude Indicator:");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 3), (float)this.bts_w, (float)(this.sl_h - 10)), this.att_indicator))
			{
				this.att_indicator_m = !this.att_indicator_m;
			}
			if (this.att_indicator_m)
			{
				this.att_indicator = "On";
			}
			if (!this.att_indicator_m)
			{
				this.att_indicator = "Off";
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 4 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Challenges:");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 4), (float)this.bts_w, (float)(this.sl_h - 10)), this.challenge_button))
			{
				this.challenge_button_m = !this.challenge_button_m;
			}
			if (this.challenge_button_m)
			{
				this.challenge_button = "On";
			}
			if (!this.challenge_button_m)
			{
				this.challenge_button = "Off";
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 5 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Wind");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 5), (float)this.bts_w, (float)(this.sl_h - 10)), "Settings Disabled"))
			{
			}
			GUI.Label(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 6 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Input Mode");
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 6), (float)this.bts_w, (float)(this.sl_h - 10)), this.input_mode[this.input_mode_change]))
			{
				this.input_mode_change++;
			}
			if (this.input_mode_change == 2)
			{
				this.input_mode_change = 3;
			}
			if (this.input_mode_change >= 5)
			{
				this.input_mode_change = 0;
			}
			if (GUI.Button(new Rect((float)(Screen.width - this.bts_w - 25), (float)(this.sl_off_h * 7 - this.sl_off_h / 3), (float)this.bts_w, (float)(this.sl_h - 10)), "Controller Settings"))
			{
				this.toggle_win2 = !this.toggle_win2;
			}
			if (this.units_switch)
			{
				this.units_standard = "Metric";
				this.units_distance = "Meters";
				this.units_velocity = "Kmph";
				this.units_Force = "Kgf";
				this.units_Weight = "Kg";
				this.units_distance_m = (float)1;
				this.units_velocity_m = 3.6f;
				this.units_Force_m = (float)1;
				this.units_Weight_m = (float)1;
			}
			else
			{
				this.units_standard = "Imperial";
				this.units_distance = "Feet";
				this.units_velocity = "Mph";
				this.units_Force = "lbf";
				this.units_Weight = "lb";
				this.units_distance_m = 3.2808f;
				this.units_velocity_m = 2.2369f;
				this.units_Force_m = 2.2046f;
				this.units_Weight_m = 2.2046f;
			}
		}
	}

	public override void Disabled_Window(int windowID)
	{
	}

	public override void Advanced_Settings_Window(int windowID)
	{
		this.Quad_cam.camera.enabled = false;
		this.Controller_cam.camera.enabled = false;
		GUI.Label(new Rect((float)Screen.width * 0.5f - (float)(this.sl_w / 2) - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)(this.sl_off_h - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Wind Direction " + this.slider_wind_direction.ToString() + " Degrees");
		this.slider_wind_direction = (int)GUI.HorizontalSlider(new Rect((float)Screen.width * 0.5f - (float)(this.sl_w / 2) - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)this.sl_off_h, (float)this.sl_w, (float)this.sl_h), (float)this.slider_wind_direction, (float)0, (float)359);
		GUI.Label(new Rect((float)Screen.width * 0.5f - (float)(this.sl_w / 2) - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)(this.sl_off_h * 2 - this.sl_off_h / 2), (float)this.sl_w, (float)(this.sl_h - 10)), "Wind Speed");
		this.slider_wind_magnitude = GUI.HorizontalSlider(new Rect((float)Screen.width * 0.5f - (float)(this.sl_w / 2) - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)(this.sl_off_h * 2), (float)this.sl_w, (float)this.sl_h), this.slider_wind_magnitude, (float)0, (float)15);
		this.wind_condition = GUI.Toggle(new Rect((float)Screen.width * 0.5f - (float)140 - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)this.sl_off_h * 3.2f - (float)(this.sl_off_h / 2), (float)280, (float)(this.sl_h - 20)), this.wind_condition, "Wind Gusts");
		if (GUI.Button(new Rect((float)Screen.width * 0.5f - (float)50 - ((float)Screen.width - (float)Screen.width * 0.75f) / (float)2, (float)this.sl_off_h * 3.5f, (float)100, (float)(this.sl_h - 10)), "Back"))
		{
			this.toggle_win = !this.toggle_win;
		}
	}

	public override void Controller_Settings_Window(int windowID)
	{
		this.Quad_cam.camera.enabled = false;
		this.Controller_cam.camera.enabled = true;
		GUI.Label(new Rect((float)Screen.width * 0.5f - (float)(this.sl_w / 2) - ((float)Screen.width - (float)Screen.width * 0.8f) / (float)2, (float)(this.sl_off_h - this.sl_off_h / 2), (float)this.sl_w, (float)((this.sl_h - 10) * 2)), "Enable Controller, Test Left / Right joysticks, Map if required");
		if (!this.controller_status)
		{
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 2 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Input: Touch");
			if (GUI.Button(new Rect((float)25, (float)(this.sl_off_h * 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Enable Controller"))
			{
				this.controller_status = true;
			}
		}
		else
		{
			GUI.Label(new Rect((float)25, (float)(this.sl_off_h * 2 - this.sl_off_h / 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Input: Controller");
			if (GUI.Button(new Rect((float)25, (float)(this.sl_off_h * 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Disable Controller"))
			{
				this.controller_status = false;
			}
			if (GUI.Button(new Rect((float)Screen.width * 0.8f - (float)this.bts_w - (float)25, (float)(this.sl_off_h * 2), (float)this.bts_w, (float)(this.sl_h - 10)), "Controller Mapping"))
			{
				PlayerPrefs.SetInt("Controller_Status", 1);
				Application.LoadLevel(9);
			}
			this.Axis_[1] = Input.GetAxis("Horizontal");
			this.Axis_[2] = Input.GetAxis("Vertical");
			this.Axis_[3] = Input.GetAxis("Third_Axis");
			this.Axis_[4] = Input.GetAxis("Fourth_Axis");
			this.Axis_[5] = Input.GetAxis("Fifth_Axis");
			this.Axis_[6] = Input.GetAxis("Sixth_Axis");
			this.Axis_[7] = Input.GetAxis("Seventh_Axis");
			this.Axis_[8] = Input.GetAxis("Eighth_Axis");
			this.Axis_[9] = Input.GetAxis("Ninth_Axis");
			this.Axis_[10] = Input.GetAxis("Tenth_Axis");
			float x = -this.Axis_[this.controller_l_h_int] * (float)this.controller_l_h_i_int * 0.25f;
			Vector3 localPosition = this.Controller_L.localPosition;
			float num = localPosition.x = x;
			Vector3 vector = this.Controller_L.localPosition = localPosition;
			float z = this.Axis_[this.controller_l_v_int] * (float)this.controller_l_v_i_int * 0.25f;
			Vector3 localPosition2 = this.Controller_L.localPosition;
			float num2 = localPosition2.z = z;
			Vector3 vector2 = this.Controller_L.localPosition = localPosition2;
			float x2 = -this.Axis_[this.controller_r_h_int] * (float)this.controller_r_h_i_int * 0.25f;
			Vector3 localPosition3 = this.Controller_R.localPosition;
			float num3 = localPosition3.x = x2;
			Vector3 vector3 = this.Controller_R.localPosition = localPosition3;
			float z2 = this.Axis_[this.controller_r_v_int] * (float)this.controller_r_v_i_int * 0.25f;
			Vector3 localPosition4 = this.Controller_R.localPosition;
			float num4 = localPosition4.z = z2;
			Vector3 vector4 = this.Controller_R.localPosition = localPosition4;
		}
		if (GUI.Button(new Rect((float)Screen.width * 0.5f - (float)50 - ((float)Screen.width - (float)Screen.width * 0.8f) / (float)2, (float)Screen.height * 0.75f - (float)50, (float)100, (float)(this.sl_h - 10)), "Back"))
		{
			this.toggle_win2 = !this.toggle_win2;
		}
	}

	public override void load_values()
	{
		this.slider_SPR = PlayerPrefs.GetFloat("Senstivity_Control");
		this.slider_SY = PlayerPrefs.GetFloat("Senstivity_Control_Yaw");
		this.slider_Auto_S = PlayerPrefs.GetFloat("Auto_Stabilize");
		this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier");
		this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier");
		this.units_standard = PlayerPrefs.GetString("Units");
		this.camera_change = PlayerPrefs.GetInt("Camera");
		this.att_indicator = PlayerPrefs.GetString("Attitude_Indicator");
		this.adv_set_enabled = PlayerPrefs.GetString("Inventory");
		this.quad_selected = PlayerPrefs.GetInt("Quad");
		this.input_mode_change = PlayerPrefs.GetInt("Input_mode");
		this.challenge_button = PlayerPrefs.GetString("Challenge_Button");
		this.aero_Drag = PlayerPrefs.GetFloat("Aerodynamic_Drag");
		if (this.quad_selected == 0)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q0");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q0");
		}
		if (this.quad_selected == 1)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q1");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q1");
		}
		if (this.quad_selected == 2)
		{
			this.slider_Thrus_M = PlayerPrefs.GetFloat("Thrust_Multiplier_Q2");
			this.slider_Mass_M = PlayerPrefs.GetFloat("Mass_Multiplier_Q2");
		}
		if (this.att_indicator == "On")
		{
			this.att_indicator_m = true;
		}
		if (this.att_indicator == "Off")
		{
			this.att_indicator_m = false;
		}
		if (this.challenge_button == "On")
		{
			this.challenge_button_m = true;
		}
		if (this.challenge_button == "Off")
		{
			this.challenge_button_m = false;
		}
		if (this.units_standard == "Metric")
		{
			this.units_switch = true;
		}
		else
		{
			this.units_switch = false;
		}
		this.slider_wind_magnitude = PlayerPrefs.GetFloat("Wind_Magnitude");
		this.slider_wind_direction = PlayerPrefs.GetInt("Wind_Direction");
		this.wind_condition_int = PlayerPrefs.GetInt("Wind_Condition");
		if (this.wind_condition_int == 0)
		{
			this.wind_condition = false;
		}
		if (this.wind_condition_int == 1)
		{
			this.wind_condition = true;
		}
		this.controller_status_int = PlayerPrefs.GetInt("Controller_Status");
		if (this.controller_status_int == 0)
		{
			this.controller_status = false;
		}
		if (this.controller_status_int == 1)
		{
			this.controller_status = true;
		}
		this.controller_l_h_int = PlayerPrefs.GetInt("Left_Horizontal_Joy");
		this.controller_l_v_int = PlayerPrefs.GetInt("Left_Vertical_Joy");
		this.controller_r_h_int = PlayerPrefs.GetInt("Right_Horizontal_Joy");
		this.controller_r_v_int = PlayerPrefs.GetInt("Right_Vertical_Joy");
		this.controller_l_h_i_int = PlayerPrefs.GetInt("Left_Horizontal_Joy_Inv");
		this.controller_l_v_i_int = PlayerPrefs.GetInt("Left_Vertical_Joy_Inv");
		this.controller_r_h_i_int = PlayerPrefs.GetInt("Right_Horizontal_Joy_Inv");
		this.controller_r_v_i_int = PlayerPrefs.GetInt("Right_Vertical_Joy_Inv");
	}

	public override void resetSliders()
	{
		PlayerPrefs.SetFloat("Senstivity_Control", 0.04f);
		PlayerPrefs.SetFloat("Senstivity_Control_Yaw", 0.01f);
		PlayerPrefs.SetFloat("Auto_Stabilize", 0.0005f);
		PlayerPrefs.SetFloat("Thrust_Multiplier", 0.1f);
		PlayerPrefs.SetFloat("Mass_Multiplier", 0.04f);
		PlayerPrefs.SetString("Units", "Imperial");
		PlayerPrefs.SetInt("Camera", 0);
		PlayerPrefs.SetString("Attitude_Indicator", "On");
		PlayerPrefs.SetString("Challenge_Button", "On");
		PlayerPrefs.SetInt("Input_mode", 0);
		PlayerPrefs.SetFloat("Aerodynamic_Drag", 0.3f);
		if (this.quad_selected == 0)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", 0.1f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q0", 0.04f);
		}
		if (this.quad_selected == 1)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", 0.09f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q1", 0.05f);
		}
		if (this.quad_selected == 2)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", 0.14f);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q2", 0.08f);
		}
		PlayerPrefs.SetInt("Challenge_selected", 0);
		PlayerPrefs.SetFloat("Wind_Magnitude", (float)0);
		PlayerPrefs.SetInt("Wind_Direction", 0);
		PlayerPrefs.SetInt("Wind_Condition", 0);
		PlayerPrefs.SetInt("Controller_Status", 1);
		this.load_values();
	}

	public override void saveSliders()
	{
		PlayerPrefs.SetFloat("Senstivity_Control", this.slider_SPR);
		PlayerPrefs.SetFloat("Senstivity_Control_Yaw", this.slider_SY);
		PlayerPrefs.SetFloat("Auto_Stabilize", this.slider_Auto_S);
		PlayerPrefs.SetFloat("Thrust_Multiplier", this.slider_Thrus_M);
		PlayerPrefs.SetFloat("Mass_Multiplier", this.slider_Mass_M);
		PlayerPrefs.SetString("Units", this.units_standard);
		PlayerPrefs.SetInt("Camera", this.camera_change);
		PlayerPrefs.SetString("Attitude_Indicator", this.att_indicator);
		PlayerPrefs.SetInt("Quad", this.quad_selected);
		PlayerPrefs.SetInt("Input_mode", this.input_mode_change);
		PlayerPrefs.SetString("Challenge_Button", this.challenge_button);
		PlayerPrefs.SetFloat("Aerodynamic_Drag", this.aero_Drag);
		if (this.quad_selected == 0)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q0", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q0", this.slider_Mass_M);
		}
		if (this.quad_selected == 1)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q1", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q1", this.slider_Mass_M);
		}
		if (this.quad_selected == 2)
		{
			PlayerPrefs.SetFloat("Thrust_Multiplier_Q2", this.slider_Thrus_M);
			PlayerPrefs.SetFloat("Mass_Multiplier_Q2", this.slider_Mass_M);
		}
		if (this.challenge_button == "Off")
		{
			PlayerPrefs.SetInt("Challenge_selected", 0);
		}
		PlayerPrefs.SetFloat("Wind_Magnitude", this.slider_wind_magnitude);
		PlayerPrefs.SetInt("Wind_Direction", this.slider_wind_direction);
		if (this.wind_condition)
		{
			this.wind_condition_int = 1;
		}
		if (!this.wind_condition)
		{
			this.wind_condition_int = 0;
		}
		PlayerPrefs.SetInt("Wind_Condition", this.wind_condition_int);
		if (this.controller_status)
		{
			this.controller_status_int = 1;
		}
		if (!this.controller_status)
		{
			this.controller_status_int = 0;
		}
		PlayerPrefs.SetInt("Controller_Status", this.controller_status_int);
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Smart_button : MonoBehaviour
{
	public Transform Quad;

	public Transform butt_off;

	public Transform Alt_Hold_button_ON;

	public Transform Alt_Hold_button_OFF;

	public Transform Crs_Lck_on;

	public Transform Crs_Lck_off;

	public Transform Hm_Lck_on;

	public Transform Hm_Lck_off;

	public Transform Pos_Hld_on;

	public Transform Pos_Hld_off;

	private int flying_mode;

	private int height_pos;

	public override void Start()
	{
		this.flying_mode = PlayerPrefs.GetInt("Flying_Mode");
	}

	public override void LateUpdate()
	{
		float width = (float)Screen.width / 7.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = (float)Screen.width / 25.6f;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float width2 = (float)Screen.width / 7.5f;
		Rect pixelInset3 = this.butt_off.guiTexture.pixelInset;
		float num3 = pixelInset3.width = width2;
		Rect rect3 = this.butt_off.guiTexture.pixelInset = pixelInset3;
		float height2 = (float)Screen.width / 25.6f;
		Rect pixelInset4 = this.butt_off.guiTexture.pixelInset;
		float num4 = pixelInset4.height = height2;
		Rect rect4 = this.butt_off.guiTexture.pixelInset = pixelInset4;
		this.height_pos = (int)((float)Screen.height / 5f + this.guiTexture.pixelInset.height * -1.25f);
		float x = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset5 = this.guiTexture.pixelInset;
		float num5 = pixelInset5.x = x;
		Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
		int num6 = Screen.height - this.height_pos;
		Rect pixelInset6 = this.guiTexture.pixelInset;
		float num7 = pixelInset6.y = (float)num6;
		Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
		float x2 = (float)Screen.width - (this.guiTexture.pixelInset.width + (float)20);
		Rect pixelInset7 = this.butt_off.guiTexture.pixelInset;
		float num8 = pixelInset7.x = x2;
		Rect rect7 = this.butt_off.guiTexture.pixelInset = pixelInset7;
		int num9 = Screen.height - this.height_pos;
		Rect pixelInset8 = this.butt_off.guiTexture.pixelInset;
		float num10 = pixelInset8.y = (float)num9;
		Rect rect8 = this.butt_off.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (!((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			int num = 0;
			Color color = this.guiTexture.color;
			float num2 = color.a = (float)num;
			Color color2 = this.guiTexture.color = color;
			float a = 0.5f;
			Color color3 = this.butt_off.guiTexture.color;
			float num3 = color3.a = a;
			Color color4 = this.butt_off.guiTexture.color = color3;
			if (this.flying_mode < 2)
			{
				this.Alt_Hold_button_ON.gameObject.SetActive(true);
				this.Alt_Hold_button_OFF.gameObject.SetActive(true);
			}
			else
			{
				this.Alt_Hold_button_ON.gameObject.SetActive(false);
				this.Alt_Hold_button_OFF.gameObject.SetActive(false);
			}
			this.Crs_Lck_on.gameObject.SetActive(false);
			this.Crs_Lck_off.gameObject.SetActive(false);
			this.Hm_Lck_on.gameObject.SetActive(false);
			this.Hm_Lck_off.gameObject.SetActive(false);
			this.Pos_Hld_on.gameObject.SetActive(false);
			this.Pos_Hld_off.gameObject.SetActive(false);
		}
		else
		{
			float a2 = 0.5f;
			Color color5 = this.guiTexture.color;
			float num4 = color5.a = a2;
			Color color6 = this.guiTexture.color = color5;
			int num5 = 0;
			Color color7 = this.butt_off.guiTexture.color;
			float num6 = color7.a = (float)num5;
			Color color8 = this.butt_off.guiTexture.color = color7;
			((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).altitude_hold = false;
			this.Alt_Hold_button_ON.gameObject.SetActive(false);
			this.Alt_Hold_button_OFF.gameObject.SetActive(false);
			this.Crs_Lck_on.gameObject.SetActive(true);
			this.Crs_Lck_off.gameObject.SetActive(true);
			this.Hm_Lck_on.gameObject.SetActive(true);
			this.Hm_Lck_off.gameObject.SetActive(true);
			this.Pos_Hld_on.gameObject.SetActive(true);
			this.Pos_Hld_off.gameObject.SetActive(true);
		}
		if (((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).sm_mode == 4)
		{
			((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode = true;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_smart();
				}
			}
		}
		if (Input.GetButtonDown("Smart"))
		{
			this.execute_smart();
		}
	}

	public override void execute_smart()
	{
		((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode = !((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode;
		if (!((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			PlayerPrefs.SetInt("Smart_Mode", 0);
		}
		if (((Quad_Dynamics_independent_propeller)this.Quad.GetComponent(typeof(Quad_Dynamics_independent_propeller))).smart_mode)
		{
			PlayerPrefs.SetInt("Smart_Mode", 1);
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class SmoothFollow2D : MonoBehaviour
{
	public Transform target;

	public float smoothTime;

	private Transform thisTransform;

	private Vector2 velocity;

	public SmoothFollow2D()
	{
		this.smoothTime = 0.1f;
	}

	public override void Start()
	{
		this.thisTransform = this.transform;
	}

	public override void Update()
	{
		float x = Mathf.SmoothDamp(this.thisTransform.position.x, this.target.position.x, ref this.velocity.x, this.smoothTime);
		Vector3 position = this.thisTransform.position;
		float num = position.x = x;
		Vector3 vector = this.thisTransform.position = position;
		float y = Mathf.SmoothDamp(this.thisTransform.position.y, this.target.position.y, ref this.velocity.y, this.smoothTime);
		Vector3 position2 = this.thisTransform.position;
		float num2 = position2.y = y;
		Vector3 vector2 = this.thisTransform.position = position2;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Speed_Display : MonoBehaviour
{
	public Transform quad_speed;

	private string units_velocity;

	private string units_standard;

	private float units_velocity_m;

	public Speed_Display()
	{
		this.units_velocity = "Mph";
		this.units_standard = "Imperial";
		this.units_velocity_m = 2.2369f;
	}

	public override void Start()
	{
		if (Screen.height > 900)
		{
			this.guiText.fontSize = 25;
		}
		else if (Screen.height > 700 && Screen.height < 900)
		{
			this.guiText.fontSize = 20;
		}
		else
		{
			this.guiText.fontSize = 15;
		}
		this.units_standard = PlayerPrefs.GetString("Units");
		if (this.units_standard == "Imperial")
		{
			this.units_velocity_m = 2.2369f;
			this.units_velocity = "Mph";
		}
		else
		{
			this.units_velocity_m = 3.6f;
			this.units_velocity = "Kph";
		}
	}

	public override void LateUpdate()
	{
		this.guiText.fontSize = Screen.height / 35;
	}

	public override void Update()
	{
		this.guiText.text = (this.quad_speed.rigidbody.velocity.magnitude * this.units_velocity_m).ToString("f0") + " " + this.units_velocity;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Sun_Flare_Follow : MonoBehaviour
{
	public Transform quad;

	public Transform cam_selected;

	public override void Start()
	{
	}

	public override void Update()
	{
		if (((Camera_GUI_Change_button)this.cam_selected.GetComponent(typeof(Camera_GUI_Change_button))).cam_sel != 0)
		{
			float x = this.quad.position.x;
			Vector3 position = this.transform.position;
			float num = position.x = x;
			Vector3 vector = this.transform.position = position;
			float y = this.quad.position.y + (float)20;
			Vector3 position2 = this.transform.position;
			float num2 = position2.y = y;
			Vector3 vector2 = this.transform.position = position2;
			float z = this.quad.position.z + (float)80;
			Vector3 position3 = this.transform.position;
			float num3 = position3.z = z;
			Vector3 vector3 = this.transform.position = position3;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class tapcontrol : MonoBehaviour
{
	public GameObject cameraObject;

	public Transform cameraPivot;

	public GUITexture jumpButton;

	public float speed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public float minimumDistanceToMove;

	public float minimumTimeUntilMove;

	public bool zoomEnabled;

	public float zoomEpsilon;

	public float zoomRate;

	public bool rotateEnabled;

	public float rotateEpsilon;

	private ZoomCamera zoomCamera;

	private Camera cam;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 targetLocation;

	private bool moving;

	private float rotationTarget;

	private float rotationVelocity;

	private Vector3 velocity;

	private ControlState state;

	private int[] fingerDown;

	private Vector2[] fingerDownPosition;

	private int[] fingerDownFrame;

	private float firstTouchTime;

	public tapcontrol()
	{
		this.inAirMultiplier = 0.25f;
		this.minimumDistanceToMove = 1f;
		this.minimumTimeUntilMove = 0.25f;
		this.rotateEpsilon = (float)1;
		this.state = ControlState.WaitingForFirstTouch;
		this.fingerDown = new int[2];
		this.fingerDownPosition = new Vector2[2];
		this.fingerDownFrame = new int[2];
	}

	public override void Start()
	{
		this.thisTransform = this.transform;
		this.zoomCamera = (ZoomCamera)this.cameraObject.GetComponent(typeof(ZoomCamera));
		this.cam = this.cameraObject.camera;
		this.character = (CharacterController)this.GetComponent(typeof(CharacterController));
		this.ResetControlState();
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if (gameObject)
		{
			this.thisTransform.position = gameObject.transform.position;
		}
	}

	public override void OnEndGame()
	{
		this.enabled = false;
	}

	public override void FaceMovementDirection()
	{
		Vector3 vector = this.character.velocity;
		vector.y = (float)0;
		if (vector.magnitude > 0.1f)
		{
			this.thisTransform.forward = vector.normalized;
		}
	}

	public override void CameraControl(Touch touch0, Touch touch1)
	{
		if (this.rotateEnabled && this.state == ControlState.RotatingCamera)
		{
			Vector2 a = touch1.position - touch0.position;
			Vector2 lhs = a / a.magnitude;
			Vector2 a2 = touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition);
			Vector2 rhs = a2 / a2.magnitude;
			float num = Vector2.Dot(lhs, rhs);
			if (num < (float)1)
			{
				Vector3 lhs2 = new Vector3(a.x, a.y);
				Vector3 rhs2 = new Vector3(a2.x, a2.y);
				float z = Vector3.Cross(lhs2, rhs2).normalized.z;
				float num2 = Mathf.Acos(num);
				this.rotationTarget += num2 * 57.29578f * z;
				if (this.rotationTarget < (float)0)
				{
					this.rotationTarget += (float)360;
				}
				else if (this.rotationTarget >= (float)360)
				{
					this.rotationTarget -= (float)360;
				}
			}
		}
		else if (this.zoomEnabled && this.state == ControlState.ZoomingCamera)
		{
			float magnitude = (touch1.position - touch0.position).magnitude;
			float magnitude2 = (touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition)).magnitude;
			float num3 = magnitude - magnitude2;
			this.zoomCamera.zoom = this.zoomCamera.zoom + num3 * this.zoomRate * Time.deltaTime;
		}
	}

	public override void CharacterControl()
	{
		int touchCount = Input.touchCount;
		if (touchCount == 1 && this.state == ControlState.MovingCharacter)
		{
			Touch touch = Input.GetTouch(0);
			if (this.character.isGrounded && this.jumpButton.HitTest(touch.position))
			{
				this.velocity = this.character.velocity;
				this.velocity.y = this.jumpSpeed;
			}
			else if (!this.jumpButton.HitTest(touch.position) && touch.phase != TouchPhase.Began)
			{
				Ray ray = this.cam.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y));
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(ray, out raycastHit))
				{
					float magnitude = (this.transform.position - raycastHit.point).magnitude;
					if (magnitude > this.minimumDistanceToMove)
					{
						this.targetLocation = raycastHit.point;
					}
					this.moving = true;
				}
			}
		}
		Vector3 vector = Vector3.zero;
		if (this.moving)
		{
			vector = this.targetLocation - this.thisTransform.position;
			vector.y = (float)0;
			float magnitude2 = vector.magnitude;
			if (magnitude2 < (float)1)
			{
				this.moving = false;
			}
			else
			{
				vector = vector.normalized * this.speed;
			}
		}
		if (!this.character.isGrounded)
		{
			this.velocity.y = this.velocity.y + Physics.gravity.y * Time.deltaTime;
			vector.x *= this.inAirMultiplier;
			vector.z *= this.inAirMultiplier;
		}
		vector += this.velocity;
		vector += Physics.gravity;
		vector *= Time.deltaTime;
		this.character.Move(vector);
		if (this.character.isGrounded)
		{
			this.velocity = Vector3.zero;
		}
		this.FaceMovementDirection();
	}

	public override void ResetControlState()
	{
		this.state = ControlState.WaitingForFirstTouch;
		this.fingerDown[0] = -1;
		this.fingerDown[1] = -1;
	}

	public override void Update()
	{
		int touchCount = Input.touchCount;
		if (touchCount == 0)
		{
			this.ResetControlState();
		}
		else
		{
			int i = 0;
			Touch touch = default(Touch);
			Touch[] touches = Input.touches;
			Touch touch2 = default(Touch);
			Touch touch3 = default(Touch);
			bool flag = false;
			bool flag2 = false;
			if (this.state == ControlState.WaitingForFirstTouch)
			{
				for (i = 0; i < touchCount; i++)
				{
					touch = touches[i];
					if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					{
						this.state = ControlState.WaitingForSecondTouch;
						this.firstTouchTime = Time.time;
						this.fingerDown[0] = touch.fingerId;
						this.fingerDownPosition[0] = touch.position;
						this.fingerDownFrame[0] = Time.frameCount;
						break;
					}
				}
			}
			if (this.state == ControlState.WaitingForSecondTouch)
			{
				for (i = 0; i < touchCount; i++)
				{
					touch = touches[i];
					if (touch.phase != TouchPhase.Canceled)
					{
						if (touchCount >= 2 && touch.fingerId != this.fingerDown[0])
						{
							this.state = ControlState.WaitingForMovement;
							this.fingerDown[1] = touch.fingerId;
							this.fingerDownPosition[1] = touch.position;
							this.fingerDownFrame[1] = Time.frameCount;
							break;
						}
						if (touchCount == 1)
						{
							Vector2 vector = touch.position - this.fingerDownPosition[0];
							if (touch.fingerId == this.fingerDown[0] && (Time.time > this.firstTouchTime + this.minimumTimeUntilMove || touch.phase == TouchPhase.Ended))
							{
								this.state = ControlState.MovingCharacter;
								break;
							}
						}
					}
				}
			}
			if (this.state == ControlState.WaitingForMovement)
			{
				for (i = 0; i < touchCount; i++)
				{
					touch = touches[i];
					if (touch.phase == TouchPhase.Began)
					{
						if (touch.fingerId == this.fingerDown[0] && this.fingerDownFrame[0] == Time.frameCount)
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId != this.fingerDown[0] && touch.fingerId != this.fingerDown[1])
						{
							this.fingerDown[1] = touch.fingerId;
							touch3 = touch;
							flag2 = true;
						}
					}
					if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
					{
						if (touch.fingerId == this.fingerDown[0])
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId == this.fingerDown[1])
						{
							touch3 = touch;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						Vector2 a = this.fingerDownPosition[1] - this.fingerDownPosition[0];
						Vector2 a2 = touch3.position - touch2.position;
						Vector2 lhs = a / a.magnitude;
						Vector2 rhs = a2 / a2.magnitude;
						float num = Vector2.Dot(lhs, rhs);
						if (num < (float)1)
						{
							float num2 = Mathf.Acos(num);
							if (num2 > this.rotateEpsilon * 0.0174532924f)
							{
								this.state = ControlState.RotatingCamera;
							}
						}
						if (this.state == ControlState.WaitingForMovement)
						{
							float f = a.magnitude - a2.magnitude;
							if (Mathf.Abs(f) > this.zoomEpsilon)
							{
								this.state = ControlState.ZoomingCamera;
							}
						}
					}
				}
				else
				{
					this.state = ControlState.WaitingForNoFingers;
				}
			}
			if (this.state == ControlState.RotatingCamera || this.state == ControlState.ZoomingCamera)
			{
				for (i = 0; i < touchCount; i++)
				{
					touch = touches[i];
					if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
					{
						if (touch.fingerId == this.fingerDown[0])
						{
							touch2 = touch;
							flag = true;
						}
						else if (touch.fingerId == this.fingerDown[1])
						{
							touch3 = touch;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						this.CameraControl(touch2, touch3);
					}
				}
				else
				{
					this.state = ControlState.WaitingForNoFingers;
				}
			}
		}
		this.CharacterControl();
	}

	public override void LateUpdate()
	{
		float y = Mathf.SmoothDampAngle(this.cameraPivot.eulerAngles.y, this.rotationTarget, ref this.rotationVelocity, 0.3f);
		Vector3 eulerAngles = this.cameraPivot.eulerAngles;
		float num = eulerAngles.y = y;
		Vector3 vector = this.cameraPivot.eulerAngles = eulerAngles;
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Test : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	private float distance_from_controller;

	public Transform controller_location;

	public Transform quad_location;

	public Test()
	{
		this.updateInterval = 0.5f;
	}

	public override void Start()
	{
		if (!this.guiText)
		{
			MonoBehaviour.print("FramesPerSecond needs a GUIText component!");
			this.enabled = false;
		}
		else
		{
			this.timeleft = this.updateInterval;
		}
	}

	public override void Update()
	{
		this.timeleft -= Time.deltaTime;
		this.accum += Time.timeScale / Time.deltaTime;
		this.frames++;
		if (this.timeleft <= (float)0)
		{
			this.distance_from_controller = Vector3.Distance(this.quad_location.position, this.controller_location.position);
			this.guiText.text = " FPS " + (this.accum / (float)this.frames).ToString("f2") + " Distance " + this.distance_from_controller.ToString("f2");
			this.timeleft = this.updateInterval;
			this.accum = (float)0;
			this.frames = 0;
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Test_Gyro : MonoBehaviour
{
	public override void Start()
	{
		if (SystemInfo.supportsGyroscope)
		{
			Input.gyro.enabled = true;
		}
	}

	public override void FixedUpdate()
	{
		this.transform.guiText.text = Input.gyro.attitude.eulerAngles.x.ToString("f2") + "\n" + Input.gyro.attitude.eulerAngles.y.ToString("f2") + "\n" + Input.gyro.attitude.eulerAngles.z.ToString("f2");
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Text_Display : MonoBehaviour
{
	public Transform close_Button;

	public Transform Never_Button;

	public Transform Text_pro;

	public Transform adv_link;

	public string url_text;

	public override void Start()
	{
		this.url_text = "market://details?id=com.Creativeworld.QuadcopterFXpro";
		float width = (float)Screen.width / 2.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = this.guiTexture.pixelInset.width / (float)4;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float x = -this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num3 = pixelInset3.x = x;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		float y = this.guiTexture.pixelInset.height / (float)4;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num4 = pixelInset4.y = y;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
		float width2 = this.guiTexture.pixelInset.width / 2.5f;
		Rect pixelInset5 = this.close_Button.guiTexture.pixelInset;
		float num5 = pixelInset5.width = width2;
		Rect rect5 = this.close_Button.guiTexture.pixelInset = pixelInset5;
		float height2 = this.guiTexture.pixelInset.height / (float)3;
		Rect pixelInset6 = this.close_Button.guiTexture.pixelInset;
		float num6 = pixelInset6.height = height2;
		Rect rect6 = this.close_Button.guiTexture.pixelInset = pixelInset6;
		float x2 = -this.guiTexture.pixelInset.x - this.close_Button.guiTexture.pixelInset.width;
		Rect pixelInset7 = this.close_Button.guiTexture.pixelInset;
		float num7 = pixelInset7.x = x2;
		Rect rect7 = this.close_Button.guiTexture.pixelInset = pixelInset7;
		float y2 = this.guiTexture.pixelInset.y - this.close_Button.guiTexture.pixelInset.height - this.close_Button.guiTexture.pixelInset.height / (float)4;
		Rect pixelInset8 = this.close_Button.guiTexture.pixelInset;
		float num8 = pixelInset8.y = y2;
		Rect rect8 = this.close_Button.guiTexture.pixelInset = pixelInset8;
		float width3 = this.guiTexture.pixelInset.width / 2.5f;
		Rect pixelInset9 = this.Never_Button.guiTexture.pixelInset;
		float num9 = pixelInset9.width = width3;
		Rect rect9 = this.Never_Button.guiTexture.pixelInset = pixelInset9;
		float height3 = this.guiTexture.pixelInset.height / (float)3;
		Rect pixelInset10 = this.Never_Button.guiTexture.pixelInset;
		float num10 = pixelInset10.height = height3;
		Rect rect10 = this.Never_Button.guiTexture.pixelInset = pixelInset10;
		float x3 = this.guiTexture.pixelInset.x;
		Rect pixelInset11 = this.Never_Button.guiTexture.pixelInset;
		float num11 = pixelInset11.x = x3;
		Rect rect11 = this.Never_Button.guiTexture.pixelInset = pixelInset11;
		float y3 = this.guiTexture.pixelInset.y - this.Never_Button.guiTexture.pixelInset.height - this.Never_Button.guiTexture.pixelInset.height / (float)4;
		Rect pixelInset12 = this.Never_Button.guiTexture.pixelInset;
		float num12 = pixelInset12.y = y3;
		Rect rect12 = this.Never_Button.guiTexture.pixelInset = pixelInset12;
	}

	public override void Update()
	{
		if (!((advertise)this.adv_link.GetComponent(typeof(advertise))).display_default)
		{
			this.url_text = ((advertise)this.adv_link.GetComponent(typeof(advertise))).text_string[0];
			this.guiTexture.texture = ((advertise)this.adv_link.GetComponent(typeof(advertise))).texture_image;
		}
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					Application.OpenURL(this.url_text);
				}
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Text_Display_Adv : MonoBehaviour
{
	public Transform close_Button;

	public Transform Text_pro;

	public override void Start()
	{
		float width = (float)Screen.width / 2.5f;
		Rect pixelInset = this.guiTexture.pixelInset;
		float num = pixelInset.width = width;
		Rect rect = this.guiTexture.pixelInset = pixelInset;
		float height = this.guiTexture.pixelInset.width / (float)4;
		Rect pixelInset2 = this.guiTexture.pixelInset;
		float num2 = pixelInset2.height = height;
		Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
		float x = -this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset3 = this.guiTexture.pixelInset;
		float num3 = pixelInset3.x = x;
		Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
		float y = this.guiTexture.pixelInset.height / (float)4;
		Rect pixelInset4 = this.guiTexture.pixelInset;
		float num4 = pixelInset4.y = y;
		Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
		float width2 = this.guiTexture.pixelInset.width / 2.5f;
		Rect pixelInset5 = this.close_Button.guiTexture.pixelInset;
		float num5 = pixelInset5.width = width2;
		Rect rect5 = this.close_Button.guiTexture.pixelInset = pixelInset5;
		float height2 = this.guiTexture.pixelInset.height / (float)3;
		Rect pixelInset6 = this.close_Button.guiTexture.pixelInset;
		float num6 = pixelInset6.height = height2;
		Rect rect6 = this.close_Button.guiTexture.pixelInset = pixelInset6;
		float x2 = -this.guiTexture.pixelInset.x - this.close_Button.guiTexture.pixelInset.width;
		Rect pixelInset7 = this.close_Button.guiTexture.pixelInset;
		float num7 = pixelInset7.x = x2;
		Rect rect7 = this.close_Button.guiTexture.pixelInset = pixelInset7;
		float y2 = this.guiTexture.pixelInset.y - this.close_Button.guiTexture.pixelInset.height - this.close_Button.guiTexture.pixelInset.height / (float)4;
		Rect pixelInset8 = this.close_Button.guiTexture.pixelInset;
		float num8 = pixelInset8.y = y2;
		Rect rect8 = this.close_Button.guiTexture.pixelInset = pixelInset8;
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					Application.LoadLevel(10);
					Application.OpenURL("market://details?id=com.Creativeworld.QuadcopterFXpro");
				}
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Tutorial_Link : MonoBehaviour
{
	private int scene_selected;

	private int Trial_Time_1;

	private int Trial_Time_2;

	private float scene_time;

	private int height_pos;

	private int width_pos;

	public override void Start()
	{
		if (Screen.height > 900)
		{
			int num = 150;
			Rect pixelInset = this.guiTexture.pixelInset;
			float num2 = pixelInset.width = (float)num;
			Rect rect = this.guiTexture.pixelInset = pixelInset;
			int num3 = 60;
			Rect pixelInset2 = this.guiTexture.pixelInset;
			float num4 = pixelInset2.height = (float)num3;
			Rect rect2 = this.guiTexture.pixelInset = pixelInset2;
			this.width_pos = 225;
			this.height_pos = 15;
		}
		else if (Screen.height > 700 && Screen.height < 900)
		{
			int num5 = 120;
			Rect pixelInset3 = this.guiTexture.pixelInset;
			float num6 = pixelInset3.width = (float)num5;
			Rect rect3 = this.guiTexture.pixelInset = pixelInset3;
			int num7 = 50;
			Rect pixelInset4 = this.guiTexture.pixelInset;
			float num8 = pixelInset4.height = (float)num7;
			Rect rect4 = this.guiTexture.pixelInset = pixelInset4;
			this.width_pos = 175;
			this.height_pos = 12;
		}
		else
		{
			int num9 = 100;
			Rect pixelInset5 = this.guiTexture.pixelInset;
			float num10 = pixelInset5.width = (float)num9;
			Rect rect5 = this.guiTexture.pixelInset = pixelInset5;
			int num11 = 40;
			Rect pixelInset6 = this.guiTexture.pixelInset;
			float num12 = pixelInset6.height = (float)num11;
			Rect rect6 = this.guiTexture.pixelInset = pixelInset6;
			this.width_pos = 150;
			this.height_pos = 10;
		}
		float x = (float)(Screen.width / 2) - this.guiTexture.pixelInset.width / (float)2;
		Rect pixelInset7 = this.guiTexture.pixelInset;
		float num13 = pixelInset7.x = x;
		Rect rect7 = this.guiTexture.pixelInset = pixelInset7;
		int num14 = this.height_pos;
		Rect pixelInset8 = this.guiTexture.pixelInset;
		float num15 = pixelInset8.y = (float)num14;
		Rect rect8 = this.guiTexture.pixelInset = pixelInset8;
		this.scene_selected = PlayerPrefs.GetInt("Scene");
		this.Trial_Time_1 = PlayerPrefs.GetInt("Scene_Try_Time_S1");
		this.Trial_Time_2 = PlayerPrefs.GetInt("Scene_Try_Time_S2");
		this.scene_time = Time.time;
	}

	public override void Update()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && this.guiTexture.HitTest(touch.position))
				{
					this.execute_reset();
				}
			}
		}
		if (Input.GetButtonDown("Reset"))
		{
			this.execute_reset();
		}
	}

	public override void execute_reset()
	{
		if (this.scene_selected == 1 && this.Trial_Time_1 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S1", (int)((float)this.Trial_Time_1 + Time.time - this.scene_time));
		}
		if (this.scene_selected == 2 && this.Trial_Time_2 < 120)
		{
			PlayerPrefs.SetInt("Scene_Try_Time_S2", (int)((float)this.Trial_Time_2 + Time.time - this.scene_time));
		}
		Application.OpenURL("https://www.youtube.com/watch?v=-6si8WkRtaY&t=1m35s");
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class VR_enable_script : MonoBehaviour
{
	private bool VR_on;

	public Transform VR_camera;

	public Transform canvas_events;

	public Transform Canvas_T;

	public Transform Main_Camera;

	public override void Start()
	{
		if (PlayerPrefs.GetInt("Camera_VR") == 1)
		{
			this.VR_on = true;
		}
		else
		{
			this.VR_on = false;
		}
		if (this.VR_on)
		{
			this.VR_camera.gameObject.SetActive(true);
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = true;
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.WorldSpace;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = true;
			this.Main_Camera.gameObject.SetActive(false);
		}
		else
		{
			((Cardboard)this.VR_camera.GetComponent(typeof(Cardboard))).VRModeEnabled = false;
			this.VR_camera.gameObject.SetActive(false);
			((Canvas)this.Canvas_T.GetComponent(typeof(Canvas))).renderMode = RenderMode.ScreenSpaceOverlay;
			((GazeInputModule)this.canvas_events.GetComponent(typeof(GazeInputModule))).enabled = false;
			this.Main_Camera.gameObject.SetActive(true);
		}
	}

	public override void Update()
	{
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Water_quad_bounce : MonoBehaviour
{
	public Transform water_ocean;

	public Transform Camera_selected;

	private int scene_selected;

	public override void Start()
	{
		this.scene_selected = PlayerPrefs.GetInt("Scene");
	}

	public override void Update()
	{
		if (this.scene_selected == 0 && this.rigidbody.transform.position.y < -7.75f)
		{
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)30 * -this.rigidbody.velocity.y, (float)0);
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)35, (float)0);
		}
		if (this.scene_selected == 1 && this.rigidbody.transform.position.y < -7.45f)
		{
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)30 * -this.rigidbody.velocity.y, (float)0);
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)35, (float)0);
			if (this.rigidbody.transform.position.y < -7.6f && ((Camera_GUI_Change_button)this.Camera_selected.GetComponent(typeof(Camera_GUI_Change_button))).cam_sel == 2)
			{
				int num = -1;
				Vector3 localScale = this.water_ocean.localScale;
				float num2 = localScale.y = (float)num;
				Vector3 vector = this.water_ocean.localScale = localScale;
			}
			else
			{
				int num3 = 1;
				Vector3 localScale2 = this.water_ocean.localScale;
				float num4 = localScale2.y = (float)num3;
				Vector3 vector2 = this.water_ocean.localScale = localScale2;
			}
		}
		if (this.scene_selected == 2 && this.rigidbody.transform.position.y < (float)-1)
		{
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)30 * -this.rigidbody.velocity.y, (float)0);
			this.rigidbody.AddForce((float)0, this.rigidbody.mass * (float)35, (float)0);
			if (this.rigidbody.transform.position.y < -1.15f && ((Camera_GUI_Change_button)this.Camera_selected.GetComponent(typeof(Camera_GUI_Change_button))).cam_sel == 2)
			{
				int num5 = -1;
				Vector3 localScale3 = this.water_ocean.localScale;
				float num6 = localScale3.y = (float)num5;
				Vector3 vector3 = this.water_ocean.localScale = localScale3;
			}
			else
			{
				int num7 = 1;
				Vector3 localScale4 = this.water_ocean.localScale;
				float num8 = localScale4.y = (float)num7;
				Vector3 vector4 = this.water_ocean.localScale = localScale4;
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class Wind_Behavior : MonoBehaviour
{
	public float wind_force;

	private float record_time;

	private float wind_time;

	private bool stop;

	private int Rand_Select;

	public Vector3 wind_direction;

	public int wind_direction_angle;

	public float wind_magnitude;

	public int wind_Behav;

	public float wind_magnitude_velocity;

	public Vector3 test;

	public float distanceToObject;

	private int random_wind_dir;

	private float aero_Drag;

	public Wind_Behavior()
	{
		this.aero_Drag = 0.3f;
	}

	public override void Start()
	{
		if (!PlayerPrefs.HasKey("Wind_Magnitude"))
		{
			PlayerPrefs.SetFloat("Wind_Magnitude", (float)0);
		}
		if (!PlayerPrefs.HasKey("Wind_Direction"))
		{
			PlayerPrefs.SetInt("Wind_Direction", 0);
		}
		if (!PlayerPrefs.HasKey("Wind_Condition"))
		{
			PlayerPrefs.SetInt("Wind_Condition", 0);
		}
		this.aero_Drag = PlayerPrefs.GetFloat("Aerodynamic_Drag");
		this.wind_magnitude_velocity = PlayerPrefs.GetFloat("Wind_Magnitude");
		this.wind_direction_angle = PlayerPrefs.GetInt("Wind_Direction");
		this.wind_Behav = PlayerPrefs.GetInt("Wind_Condition");
	}

	public override void FixedUpdate()
	{
		if (this.wind_magnitude_velocity > (float)0)
		{
			if (!this.stop)
			{
				this.record_time = Time.time;
				this.Rand_Select = UnityEngine.Random.Range(1, 6);
				if (this.wind_Behav != 0)
				{
					if (this.Rand_Select == 1)
					{
						this.wind_force = this.wind_magnitude * (float)0;
					}
					if (this.Rand_Select == 2)
					{
						this.wind_force = this.wind_magnitude * 0.1f;
					}
					if (this.Rand_Select == 3)
					{
						this.wind_force = this.wind_magnitude * 0.12f;
					}
					if (this.Rand_Select == 4)
					{
						this.wind_force = this.wind_magnitude * 0.13f;
					}
					if (this.Rand_Select == 5)
					{
						this.wind_force = this.wind_magnitude * 0.7f;
					}
					if (this.Rand_Select == 6)
					{
						this.wind_force = this.wind_magnitude * 1f;
					}
				}
				else
				{
					if (this.Rand_Select == 1)
					{
						this.wind_force = this.wind_magnitude * 0.25f;
					}
					if (this.Rand_Select == 2)
					{
						this.wind_force = this.wind_magnitude * 0.2f;
					}
					if (this.Rand_Select == 3)
					{
						this.wind_force = this.wind_magnitude * 0.26f;
					}
					if (this.Rand_Select == 4)
					{
						this.wind_force = this.wind_magnitude * 0.3f;
					}
					if (this.Rand_Select == 5)
					{
						this.wind_force = this.wind_magnitude * 0.35f;
					}
					if (this.Rand_Select == 6)
					{
						this.wind_force = this.wind_magnitude * 0.2f;
					}
				}
				int layerMask = -2049;
				RaycastHit raycastHit = default(RaycastHit);
				if (Physics.Raycast(this.transform.position, -this.wind_direction, out raycastHit, (float)20, layerMask))
				{
					this.distanceToObject = raycastHit.distance;
					if (this.distanceToObject < (float)1)
					{
						this.wind_force *= (float)0;
					}
					if (this.distanceToObject > (float)5)
					{
						this.wind_force *= 0.1f;
					}
					if (this.distanceToObject > (float)10)
					{
						this.wind_force *= 0.3f;
					}
					if (this.distanceToObject > (float)15)
					{
						this.wind_force *= 0.5f;
					}
					if (this.distanceToObject > (float)20)
					{
						this.wind_force *= (float)1;
					}
				}
				else
				{
					this.distanceToObject = (float)20;
				}
				this.random_wind_dir = UnityEngine.Random.Range(this.wind_direction_angle - 5, this.wind_direction_angle + 5);
				this.wind_time = UnityEngine.Random.Range(0.1f, (float)3);
				this.stop = true;
			}
			this.wind_direction = Quaternion.AngleAxis((float)this.random_wind_dir, Vector3.up) * Vector3.right;
			this.rigidbody.AddForce(this.wind_force * this.rigidbody.mass * (this.wind_direction.x * (this.wind_magnitude_velocity - this.rigidbody.velocity.x)) * this.aero_Drag, (float)0, (float)0);
			this.rigidbody.AddForce((float)0, (float)0, this.wind_force * this.rigidbody.mass * (this.wind_direction.z * (this.wind_magnitude_velocity - this.rigidbody.velocity.z)) * this.aero_Drag);
			if (this.wind_Behav != 0)
			{
				this.rigidbody.AddTorque((float)0, (float)0, this.wind_direction.x * this.wind_force * 0.005f * this.aero_Drag);
				this.rigidbody.AddTorque(this.wind_direction.z * this.wind_force * 0.005f * this.aero_Drag, (float)0, (float)0);
			}
			if (Time.time > this.record_time + this.wind_time)
			{
				this.stop = false;
			}
		}
	}

	public override void Main()
	{
	}
}

using System;
using UnityEngine;

[Serializable]
public class ZoomCamera : MonoBehaviour
{
	public Transform origin;

	public float zoom;

	public float zoomMin;

	public float zoomMax;

	public float seekTime;

	public bool smoothZoomIn;

	private Vector3 defaultLocalPosition;

	private Transform thisTransform;

	private float currentZoom;

	private float targetZoom;

	private float zoomVelocity;

	public ZoomCamera()
	{
		this.zoomMin = (float)-5;
		this.zoomMax = (float)5;
		this.seekTime = 1f;
	}

	public override void Start()
	{
		this.thisTransform = this.transform;
		this.defaultLocalPosition = this.thisTransform.localPosition;
		this.currentZoom = this.zoom;
	}

	public override void Update()
	{
		this.zoom = Mathf.Clamp(this.zoom, this.zoomMin, this.zoomMax);
		int layerMask = -261;
		RaycastHit raycastHit = default(RaycastHit);
		Vector3 position = this.origin.position;
		Vector3 vector = this.defaultLocalPosition + this.thisTransform.parent.InverseTransformDirection(this.thisTransform.forward * this.zoom);
		Vector3 end = this.thisTransform.parent.TransformPoint(vector);
		if (Physics.Linecast(position, end, out raycastHit, layerMask))
		{
			Vector3 a = raycastHit.point + this.thisTransform.TransformDirection(Vector3.forward);
			this.targetZoom = (a - this.thisTransform.parent.TransformPoint(this.defaultLocalPosition)).magnitude;
		}
		else
		{
			this.targetZoom = this.zoom;
		}
		this.targetZoom = Mathf.Clamp(this.targetZoom, this.zoomMin, this.zoomMax);
		if (!this.smoothZoomIn && this.targetZoom - this.currentZoom > (float)0)
		{
			this.currentZoom = this.targetZoom;
		}
		else
		{
			this.currentZoom = Mathf.SmoothDamp(this.currentZoom, this.targetZoom, ref this.zoomVelocity, this.seekTime);
		}
		vector = this.defaultLocalPosition + this.thisTransform.parent.InverseTransformDirection(this.thisTransform.forward * this.currentZoom);
		this.thisTransform.localPosition = vector;
	}

	public override void Main()
	{
	}
}
