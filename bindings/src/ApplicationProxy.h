class ApplicationProxy;

typedef void(*callback_t)(ApplicationProxy *);
typedef int(*sdl_callback)(Urho3D::Context *);
typedef void(*RefCountedEventCallback)(void *, Urho3D::RefCountedEvent);

class ApplicationProxy : public Urho3D::Application {
public:
	ApplicationProxy (Urho3D::Context *ctx, callback_t csetup, callback_t cstart, callback_t cstop) : Urho3D::Application (ctx)
	{
		setup = csetup;
		start = cstart;
		stop = cstop;
	}

	void Setup ()
	{
		engineParameters_["FullScreen"] = false;
		engineParameters_["Headless"] = false;
		engineParameters_["FrameLimiter"] = true;
		setup (this);
	}

	void Start ()
	{
		start (this);
	}

	void Stop ()
	{
		stop (this);
	}

	Urho3D::Engine *GetEngine ()
	{
		return engine_.Get ();
	}
	
private:
	callback_t setup, start, stop;
};
