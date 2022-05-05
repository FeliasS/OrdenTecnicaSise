package crc64101ab38e3d43aafd;


public class ListOrden_Item
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OrdenTecnica_App.ListRecycler.Holder.ListOrden_Item, OrdenTecnica_App", ListOrden_Item.class, __md_methods);
	}


	public ListOrden_Item (android.view.View p0)
	{
		super (p0);
		if (getClass () == ListOrden_Item.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.ListRecycler.Holder.ListOrden_Item, OrdenTecnica_App", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
