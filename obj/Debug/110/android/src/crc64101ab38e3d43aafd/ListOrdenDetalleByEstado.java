package crc64101ab38e3d43aafd;


public class ListOrdenDetalleByEstado
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OrdenTecnica_App.ListRecycler.Holder.ListOrdenDetalleByEstado, OrdenTecnica_App", ListOrdenDetalleByEstado.class, __md_methods);
	}


	public ListOrdenDetalleByEstado (android.view.View p0)
	{
		super (p0);
		if (getClass () == ListOrdenDetalleByEstado.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.ListRecycler.Holder.ListOrdenDetalleByEstado, OrdenTecnica_App", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
