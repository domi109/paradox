// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Data Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxdata.
// </auto-generated>

namespace SiliconStudio.Paradox.Effects.Data
{
    /// <summary>
    /// Module initializer for data types of assembly SiliconStudio.Paradox.Effects.
    /// </summary>
    class DataInitializer
    {
        [SiliconStudio.Core.ModuleInitializer]
        internal static void Initialize()
        {
            // Register type CubemapBlendComponentData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentDataConverter());
            // Register entity component reference for type CubemapBlendComponentData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Data.EntityComponentReferenceDataConverter<SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent>());
            // Register type CubemapSourceComponentData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentDataConverter());
            // Register entity component reference for type CubemapSourceComponentData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Data.EntityComponentReferenceDataConverter<SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent>());
        }
    }
}

namespace SiliconStudio.Paradox.Effects.Cubemap.Data
{
    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("CubemapBlendComponentData")]
    public partial class CubemapBlendComponentData : SiliconStudio.Paradox.EntityModel.Data.EntityComponentData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent.Enabled"/>.
        /// </summary>
        public System.Boolean Enabled;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent.Size"/>.
        /// </summary>
        public System.Int32 Size;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent.MaxBlendCount"/>.
        /// </summary>
        public System.Int32 MaxBlendCount;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent.TextureKey"/>.
        /// </summary>
        public SiliconStudio.Paradox.Effects.ParameterKey<SiliconStudio.Paradox.Graphics.Texture> TextureKey;
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("CubemapSourceComponentData")]
    public partial class CubemapSourceComponentData : SiliconStudio.Paradox.EntityModel.Data.EntityComponentData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.Enabled"/>.
        /// </summary>
        public System.Boolean Enabled;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.IsDynamic"/>.
        /// </summary>
        public System.Boolean IsDynamic;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.Size"/>.
        /// </summary>
        public System.Int32 Size;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.InfinityCubemap"/>.
        /// </summary>
        public System.Boolean InfinityCubemap;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.InfluenceRadius"/>.
        /// </summary>
        public System.Single InfluenceRadius;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.NearPlane"/>.
        /// </summary>
        public System.Single NearPlane;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.FarPlane"/>.
        /// </summary>
        public System.Single FarPlane;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent.Texture"/>.
        /// </summary>
        public SiliconStudio.Core.Serialization.ContentReference<SiliconStudio.Paradox.Graphics.Texture> Texture;
    }



    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent"/>.
    /// </summary>
    public partial class CubemapBlendComponentDataConverter : SiliconStudio.Paradox.EntityModel.Data.EntityComponentDataConverter	
	{
		/// <inheritdoc/>
		public override System.Type DataType
		{
			get { return typeof(SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData); }
		}

		/// <inheritdoc/>
		public override System.Type ObjectType
		{
			get { return typeof(SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent); }
		}
				
        /// <inheritdoc/>
        public override void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, object data, ref object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent)obj;
            ConvertFromData(converterContext, dataT, ref objT);
            obj = objT;
        }
		
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, ref object data, object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent)obj;
            ConvertToData(converterContext, ref dataT, objT);
            data = dataT;
        }

		        /// <inheritdoc/>
        public void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData target, SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData();
				
			{
				var targetBase = (SiliconStudio.Paradox.EntityModel.Data.EntityComponentData)target;
				var sourceBase = (SiliconStudio.Paradox.EntityModel.EntityComponent)source;
				ConvertToData(context, ref targetBase, sourceBase);
			}

            target.Enabled = source.Enabled;
            target.Size = source.Size;
            target.MaxBlendCount = source.MaxBlendCount;
            target.TextureKey = source.TextureKey;
        }

        public override bool CanConstruct
        {
            get { return true; }
        }
		
		
        /// <inheritdoc/>
        public override void ConstructFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, object data, ref object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent)obj;
            ConstructFromData(converterContext, dataT, ref objT);
            obj = objT;
        }

		/// <inheritdoc/>
        public void ConstructFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData target, ref SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent source)
		{
			source = new SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent();
		}

        /// <inheritdoc/>
        public void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapBlendComponentData target, ref SiliconStudio.Paradox.Effects.Cubemap.CubemapBlendComponent source)
        {
            source.Enabled = target.Enabled;
            source.Size = target.Size;
            source.MaxBlendCount = target.MaxBlendCount;
            source.TextureKey = target.TextureKey;
        }
    }

    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent"/>.
    /// </summary>
    public partial class CubemapSourceComponentDataConverter : SiliconStudio.Paradox.EntityModel.Data.EntityComponentDataConverter	
	{
		/// <inheritdoc/>
		public override System.Type DataType
		{
			get { return typeof(SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData); }
		}

		/// <inheritdoc/>
		public override System.Type ObjectType
		{
			get { return typeof(SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent); }
		}
				
        /// <inheritdoc/>
        public override void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, object data, ref object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent)obj;
            ConvertFromData(converterContext, dataT, ref objT);
            obj = objT;
        }
		
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, ref object data, object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent)obj;
            ConvertToData(converterContext, ref dataT, objT);
            data = dataT;
        }

		        /// <inheritdoc/>
        public void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData target, SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData();
				
			{
				var targetBase = (SiliconStudio.Paradox.EntityModel.Data.EntityComponentData)target;
				var sourceBase = (SiliconStudio.Paradox.EntityModel.EntityComponent)source;
				ConvertToData(context, ref targetBase, sourceBase);
			}

            target.Enabled = source.Enabled;
            target.IsDynamic = source.IsDynamic;
            target.Size = source.Size;
            target.InfinityCubemap = source.InfinityCubemap;
            target.InfluenceRadius = source.InfluenceRadius;
            target.NearPlane = source.NearPlane;
            target.FarPlane = source.FarPlane;
            context.ConvertToData(ref target.Texture, source.Texture);
        }

        public override bool CanConstruct
        {
            get { return true; }
        }
		
		
        /// <inheritdoc/>
        public override void ConstructFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, object data, ref object obj)
        {
            var dataT = (SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData)data;
            var objT = (SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent)obj;
            ConstructFromData(converterContext, dataT, ref objT);
            obj = objT;
        }

		/// <inheritdoc/>
        public void ConstructFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData target, ref SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent source)
		{
			source = new SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent();
		}

        /// <inheritdoc/>
        public void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Effects.Cubemap.Data.CubemapSourceComponentData target, ref SiliconStudio.Paradox.Effects.Cubemap.CubemapSourceComponent source)
        {
            source.Enabled = target.Enabled;
            source.IsDynamic = target.IsDynamic;
            source.Size = target.Size;
            source.InfinityCubemap = target.InfinityCubemap;
            source.InfluenceRadius = target.InfluenceRadius;
            source.NearPlane = target.NearPlane;
            source.FarPlane = target.FarPlane;
            {
                var temp = source.Texture;
                context.ConvertFromData(target.Texture, ref temp);
                source.Texture = temp;
            }
        }
    }

}

