﻿using Unity.MARS;
using Unity.XRTools.ModuleLoader;
using UnityEditor.MARS.Simulation;
using UnityEngine;

namespace UnityEditor.MARS
{
    class FaceLandmarkVisualizerObjectCreationData : ObjectCreationData
    {
        public override bool CreateGameObject(out GameObject createdObj, Transform parentTransform = null)
        {
            MARSSession.EnsureRuntimeState();

            createdObj = GenerateInitialGameObject(m_ObjectName, parentTransform);

            createdObj.AddComponent<MRFaceLandmarkVisualizer>();

            Undo.RegisterCreatedObjectUndo(createdObj, $"Create {createdObj.name}");
            Selection.activeGameObject = createdObj;

            var simObjectsManager = ModuleLoaderCore.instance.GetModule<SimulatedObjectsManager>();
            simObjectsManager?.DirtySimulatableScene();

            return true;
        }
    }
}
