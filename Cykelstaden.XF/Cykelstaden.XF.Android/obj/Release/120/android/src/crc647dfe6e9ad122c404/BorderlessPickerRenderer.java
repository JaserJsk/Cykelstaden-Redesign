package crc647dfe6e9ad122c404;


public class BorderlessPickerRenderer
	extends crc64720bb2db43a66fe9.PickerRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Cykelstaden.XF.Droid.Renderers.BorderlessPickerRenderer, Cykelstaden.XF.Android", BorderlessPickerRenderer.class, __md_methods);
	}


	public BorderlessPickerRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == BorderlessPickerRenderer.class)
			mono.android.TypeManager.Activate ("Cykelstaden.XF.Droid.Renderers.BorderlessPickerRenderer, Cykelstaden.XF.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public BorderlessPickerRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == BorderlessPickerRenderer.class)
			mono.android.TypeManager.Activate ("Cykelstaden.XF.Droid.Renderers.BorderlessPickerRenderer, Cykelstaden.XF.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public BorderlessPickerRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == BorderlessPickerRenderer.class)
			mono.android.TypeManager.Activate ("Cykelstaden.XF.Droid.Renderers.BorderlessPickerRenderer, Cykelstaden.XF.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}