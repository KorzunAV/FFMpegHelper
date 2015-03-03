﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFMpegHelper.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FFMpegHelper.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Критическая.
        /// </summary>
        internal static string ErrorCritical {
            get {
                return ResourceManager.GetString("ErrorCritical", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка удаление {0}.
        /// </summary>
        internal static string ErrorFileDelete {
            get {
                return ResourceManager.GetString("ErrorFileDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка удаления файла {0}. Исчерпан лимит повторов.
        /// </summary>
        internal static string ErrorFileDeleteLimit {
            get {
                return ResourceManager.GetString("ErrorFileDeleteLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка перемещения {0}-&gt;{1}.
        /// </summary>
        internal static string ErrorFileMove {
            get {
                return ResourceManager.GetString("ErrorFileMove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка перемещения файла {0}. Файл не существует..
        /// </summary>
        internal static string ErrorFileMoveFileNotFound {
            get {
                return ResourceManager.GetString("ErrorFileMoveFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка перемещения файла {0}. Исчерпан лимит повторов.
        /// </summary>
        internal static string ErrorFileMoveLimit {
            get {
                return ResourceManager.GetString("ErrorFileMoveLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка перемещения файла {0}. Файл уже существует. Переписать файл?.
        /// </summary>
        internal static string ErrorFileMoveTryContinue {
            get {
                return ResourceManager.GetString("ErrorFileMoveTryContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Удаление {0}.
        /// </summary>
        internal static string FileDelete {
            get {
                return ResourceManager.GetString("FileDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Перемещение {0}-&gt;{1}.
        /// </summary>
        internal static string FileMove {
            get {
                return ResourceManager.GetString("FileMove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подготовка программы к работе. Поиск файлов..
        /// </summary>
        internal static string PreparingToWork {
            get {
                return ResourceManager.GetString("PreparingToWork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Файл {1}. {0}Обработано {2} из {3} ({4:0.0} из {5:0.0} мегабайт). {0}Время работы {6:0.0} минут. {0}Освободилось {7:0.0} мегабайт. {0}Примерное время работы: {8:0.0} минут..
        /// </summary>
        internal static string StateMessage1 {
            get {
                return ResourceManager.GetString("StateMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Обработано {1} из {2} ({3:0.0} из {4:0.0} мегабайт). {0}Освободилось {5:0.0} мегабайт. {0}Време работы {5:0.0} минут. {0}Обработка завершена..
        /// </summary>
        internal static string StateMessage2 {
            get {
                return ResourceManager.GetString("StateMessage2", resourceCulture);
            }
        }
    }
}