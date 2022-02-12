package crc64101ab38e3d43aafd;


public class ListTecnicos
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("OrdenTecnica_App.ListRecycler.Holder.ListTecnicos, OrdenTecnica_App", ListTecnicos.class, __md_methods);
	}


	public ListTecnicos (android.view.View p0)
	{
		super (p0);
		if (getClass () == ListTecnicos.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.ListRecycler.Holder.ListTecnicos, OrdenTecnica_App", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
