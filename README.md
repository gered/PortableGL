PortableGL
==========

This is a interface over platform/framework specific OpenGL bindings for C#.

The idea is to allow core application code to still include OpenGL calls by
referencing a Portable Class Library which contains an interface with the
OpenGL methods without any platform or OS-specifics. Final application builds
will also reference a "backend" assembly which contains the actual OpenGL
binding code (e.g. OpenTK, SDL2-CS, Xamarin.Android, etc).

At the moment, the OpenGL ES 2.0 specification is used as the sole interface
available for both mobile and desktop platforms. I have no intention to add
any other specifications over the short-term (such as OpenGL 1.x, 3.x, etc).
My own personal goals with this library are simply to use the ES specification
for both mobile and desktop platforms to make code portability between the two
simpler.

C-style naming for the methods and OpenGL constants is intentionally left as-is
to aid in porting existing OpenGL code. I don't intend to C#-ify much, if any,
of the OpenGL methods (such as using specific enums for certain parameters).

# TODO

* Mobile backends: Xamarin.Android, Xamarin.iOS
* Add additional method overloads to PortableGL to make it easier to pass arrays of data, out parameters, etc instead of needing to use pointers all the time
