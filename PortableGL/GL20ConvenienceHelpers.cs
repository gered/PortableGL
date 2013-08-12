using System;
using System.Text;

namespace PortableGL
{
	// This is where "convenience" overloads for commonly used OpenGL functions
	// can go. The intention here is to provide ways to reduce some repetitive
	// code on the caller-side. These overloads will not exactly match the
	// OpenGL ES 2.0 spec obviously.
	//
	// Overloads here should really be kept to a bare minimum!

	public abstract partial class GL20
	{
		public void glDeleteBuffers(int buffer)
		{
			glDeleteBuffers(1, ref buffer);
		}

		public void glDeleteFramebuffers(int framebuffer)
		{
			glDeleteFramebuffers(1, ref framebuffer);
		}

		public void glDeleteRenderbuffers(int renderbuffer)
		{
			glDeleteRenderbuffers(1, ref renderbuffer);
		}

		public void glDeleteTextures(int texture)
		{
			glDeleteTextures(1, ref texture);
		}

		public int glGenBuffers()
		{
			int buffer = 0;
			glGenBuffers(1, ref buffer);
			return buffer;
		}

		public int glGenFramebuffers()
		{
			int framebuffer = 0;
			glGenFramebuffers(1, ref framebuffer);
			return framebuffer;
		}

		public int glGenRenderbuffers()
		{
			int renderbuffer = 0;
			glGenRenderbuffers(1, ref renderbuffer);
			return renderbuffer;
		}

		public int glGenTextures()
		{
			int texture = 0;
			glGenTextures(1, ref texture);
			return texture;
		}

		public string glGetActiveAttrib(int program, int index, out int size, out int type)
		{
			int length = glGetProgramiv(program, GL_ACTIVE_ATTRIBUTE_MAX_LENGTH);
			StringBuilder sb = new StringBuilder(length == 0 ? 1 : length);
			glGetActiveAttrib(program, index, sb.Capacity, out length, out size, out type, sb);
			return sb.ToString();
		}

		public string glGetActiveUniform(int program, int index, out int size, out int type)
		{
			int length = glGetProgramiv(program, GL_ACTIVE_UNIFORM_MAX_LENGTH);
			StringBuilder sb = new StringBuilder(length == 0 ? 1 : length);
			glGetActiveUniform(program, index, sb.Capacity, out length, out size, out type, sb);
			return sb.ToString();
		}

		public string glGetProgramInfoLog(int program)
		{
			int length = glGetProgramiv(program, GL_INFO_LOG_LENGTH);
			if (length == 0)
				return String.Empty;
			StringBuilder sb = new StringBuilder(length);
			glGetProgramInfoLog(program, sb.Capacity, out length, sb);
			return sb.ToString();
		}

		public int glGetProgramiv(int shader, int pname)
		{
			int parameter = 0;
			glGetProgramiv(shader, pname, ref parameter);
			return parameter;
		}

		public string glGetShaderInfoLog(int shader)
		{
			int length = glGetShaderiv(shader, GL_INFO_LOG_LENGTH);
			if (length == 0)
				return String.Empty;
			StringBuilder sb = new StringBuilder(length);
			glGetShaderInfoLog(shader, sb.Capacity, out length, sb);
			return sb.ToString();
		}

		public string glGetShaderSource(int shader)
		{
			int length = glGetShaderiv(shader, GL_SHADER_SOURCE_LENGTH);
			if (length == 0)
				return String.Empty;
			StringBuilder sb = new StringBuilder(length);
			glGetShaderSource(shader, sb.Capacity, out length, sb);
			return sb.ToString();
		}

		public int glGetShaderiv(int shader, int pname)
		{
			int parameter = 0;
			glGetShaderiv(shader, pname, ref parameter);
			return parameter;
		}

		public float glGetTexParameterfv(int target, int pname)
		{
			float parameter = 0.0f;
			glGetTexParameterfv(target, pname, ref parameter);
			return parameter;
		}

		public int glGetTexParameteriv(int target, int pname)
		{
			int parameter = 0;
			glGetTexParameteriv(target, pname, ref parameter);
			return parameter;
		}

		public void glShaderSource(int shader, string str)
		{
			glShaderSource(shader, 1, new string[] { str }, new int[] { str.Length });
		}

	}
}

