package crc64d818c4686ed024a0;


public class OrdenCreada_Fragment
	extends androidx.fragment.app.Fragment
	implements
		mono.android.IGCUserPeer,
		android.widget.SearchView.OnQueryTextListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttach:(Landroid/content/Context;)V:GetOnAttach_Landroid_content_Context_Handler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onQueryTextChange:(Ljava/lang/String;)Z:GetOnQueryTextChange_Ljava_lang_String_Handler:Android.Widget.SearchView/IOnQueryTextListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onQueryTextSubmit:(Ljava/lang/String;)Z:GetOnQueryTextSubmit_Ljava_lang_String_Handler:Android.Widget.SearchView/IOnQueryTextListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("OrdenTecnica_App.Fragments.OrdenCreada_Fragment, OrdenTecnica_App", OrdenCreada_Fragment.class, __md_methods);
	}


	public OrdenCreada_Fragment ()
	{
		super ();
		if (getClass () == OrdenCreada_Fragment.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.Fragments.OrdenCreada_Fragment, OrdenTecnica_App", "", this, new java.lang.Object[] {  });
	}


	public OrdenCreada_Fragment (int p0)
	{
		super (p0);
		if (getClass () == OrdenCreada_Fragment.class)
			mono.android.TypeManager.Activate ("OrdenTecnica_App.Fragments.OrdenCreada_Fragment, OrdenTecnica_App", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onAttach (android.content.Context p0)
	{
		n_onAttach (p0);
	}

	private native void n_onAttach (android.content.Context p0);


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public boolean onQueryTextChange (java.lang.String p0)
	{
		return n_onQueryTextChange (p0);
	}

	private native boolean n_onQueryTextChange (java.lang.String p0);


	public boolean onQueryTextSubmit (java.lang.String p0)
	{
		return n_onQueryTextSubmit (p0);
	}

	private native boolean n_onQueryTextSubmit (java.lang.String p0);

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
