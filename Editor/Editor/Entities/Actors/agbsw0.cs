using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;
using OpenTK;

namespace WindEditor
{
	public partial class agbsw0
	{
		public override void PostLoad()
		{
			base.PostLoad();

            UpdateModel();
        }

        public override void PreSave()
		{

        }

        public override void AddToRenderer(WSceneView view)
        {
            view.AddTransparentMesh(this);
        }

        private void UpdateModel()
        {
            // Note: Not sure if all of the types are cylinders.
            m_RegionAreaModel = WResourceManager.LoadObjResource("resources/editor/EditorCylinder.obj", new Vector4(1f, 1f, 1f, 1f), true, false);

            // Note: Note sure if all these scales are right.
            //if (Type == TypeEnum.agbCSW)
            //{
            //    VisualScaleMultiplier = new Vector3(8000f / 50f, 8000f / 50f, 8000f / 50f);
            //}
            //else if (Type == TypeEnum.agbB)
            //{
            //    VisualScaleMultiplier = new Vector3(100f / 50f, 100f / 50f, 100f / 50f);
            //}
            //else
            //{
            //    VisualScaleMultiplier = new Vector3(200f / 50f, 200f / 50f, 200f / 50f);
            //}
            VisualScaleMultiplier = new Vector3(100f / 50f, 100f / 50f, 100f / 50f);
        }

        public override void CalculateUsedSwitches()
        {
            List<int> inSwitches = new List<int>();
            List<int> outSwitches = new List<int>();

            switch (Type)
            {
                case TypeEnum.Tingle_Bomb_Trigger:
                    inSwitches.Add(BombedSwitch);
                    outSwitches.Add(BombedSwitch);
                    break;
                case TypeEnum.Secret_Item_Trigger:
                    inSwitches.Add(SecretItemSpawnedSwitch);
                    outSwitches.Add(SecretItemSpawnedSwitch);
                    break;
                // TODO: other types
            }

            inSwitches.RemoveAll(x => x == 0xFF);
            outSwitches.RemoveAll(x => x == 0xFF);
            UsedInSwitches = inSwitches;
            UsedOutSwitches = outSwitches;
        }
    }
}
