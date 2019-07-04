using Game.Runtime;
using GameFramework;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityGameFrame.Editor.Processor;

namespace Game.Editor
{	
	public sealed class ConfigGenerator
	{
	    //创建数据表处理器
	    public static ConfigProcessor CreateConfigProcessor(string dataTableName)
	    {
	        return new ConfigProcessor(Utility.Path.GetCombinePath(RuntimeAssetUtility.ConfigPath, dataTableName + RuntimeAssetUtility.csvExtension), Encoding.UTF8, 1, 2);
	    }
	
	    //生成数据文件
	    public static void GenerateDataFile(ConfigProcessor configProcessor, string configName)
	    {
	        string binaryConfigFileName = Utility.Path.GetCombinePath(RuntimeAssetUtility.ConfigPath, configName + RuntimeAssetUtility.bytesExtension);   //二进制的数据文件名
	        if (!configProcessor.GenerateConfigFile(binaryConfigFileName, Encoding.UTF8) && File.Exists(binaryConfigFileName))
	        {
	            //创建失败，并且文件存在，则删除
	            File.Delete(binaryConfigFileName);
	            Debug.LogError(Utility.Text.Format("失败:生成配置表文件 -> {0}", configName));
	        }
	
	        AssetDatabase.Refresh();
	    }
	
	}
}
