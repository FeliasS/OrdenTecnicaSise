package crc64fac4dc6930c9ca92;


public class ItemSucursal_ac
	extends android.widget.ArrayAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OrdenTecnica_App.ListRecycler.Adapter.ItemSucursal_ac, OrdenTecnica_App", ItemSucursal_ac.class, __md_methods);
	}


	public ItemSucursal_ac (android.content.Context p0, int p1, java.lang.Object[] p2)
	{
		super (p0, p1, p2);
		if (getClass () == ItemSucursal_ac.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.ListRecycler.Adapter.ItemSucursal_ac, OrdenTecnica_App", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:T[], Mono.Android", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ItemSucursal_ac (android.content.Context p0, int p1, java.util.List p2)
	{
		super (p0, p1, p2);
		if (getClass () == ItemSucursal_ac.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.ListRecycler.Adapter.ItemSucursal_ac, OrdenTecnica_App", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Collections.Generic.IList`1<T>, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
