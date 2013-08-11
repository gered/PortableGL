using System;
using OpenTK.Graphics.OpenGL;

namespace PortableGL.SDL
{
	public class SDLGL20 : GL20
	{
		public override void glActiveTexture(int texture)
		{
			GL.ActiveTexture((TextureUnit)texture);
		}

		public override void glAttachShader(int program, int shader)
		{
			GL.AttachShader(program, shader);
		}

		public override void glBindAttribLocation(int program, int index, string name)
		{
			GL.BindAttribLocation(program, index, name);
		}

		public override void glBindBuffer(int target, int buffer)
		{
			GL.BindBuffer((BufferTarget)target, buffer);
		}

		public override void glBindFramebuffer(int target, int framebuffer)
		{
			GL.BindFramebuffer((FramebufferTarget)target, framebuffer);
		}

		public override void glBindRenderbuffer(int target, int renderbuffer)
		{
			GL.BindRenderbuffer((RenderbufferTarget)target, renderbuffer);
		}

		public override void glBindTexture(int target, int texture)
		{
			GL.BindTexture((TextureTarget)target, texture);
		}

		public override void glBlendColor(float red, float green, float blue, float alpha)
		{
			GL.BlendColor(red, green, blue, alpha);
		}

		public override void glBlendEquation(int mode)
		{
			GL.BlendEquation((BlendEquationMode)mode);
		}

		public override void glBlendEquationSeparate(int modeRGB, int modeAlpha)
		{
			GL.BlendEquationSeparate((BlendEquationMode)modeRGB, (BlendEquationMode)modeAlpha);
		}

		public override void glBlendFunc(int sfactor, int dfactor)
		{
			GL.BlendFunc((BlendingFactorSrc)sfactor, (BlendingFactorDest)dfactor);
		}

		public override void glBlendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			GL.BlendFuncSeparate((BlendingFactorSrc)srcRGB, (BlendingFactorDest)dstRGB, (BlendingFactorSrc)srcAlpha, (BlendingFactorDest)dstAlpha);
		}

		public override void glBufferData(int target, int size, IntPtr data, int usage)
		{
			GL.BufferData((BufferTarget)target, (IntPtr)size, data, (BufferUsageHint)usage);
		}

		public override void glBufferSubData(int target, int offset, int size, IntPtr data)
		{
			GL.BufferSubData((BufferTarget)target, (IntPtr)offset, (IntPtr)size, data);
		}

		public override int glCheckFramebufferStatus(int target)
		{
			return (int)GL.CheckFramebufferStatus((FramebufferTarget)target);
		}

		public override void glClear(int mask)
		{
			GL.Clear((ClearBufferMask)mask);
		}

		public override void glClearColor(float red, float green, float blue, float alpha)
		{
			GL.ClearColor(red, green, blue, alpha);
		}

		public override void glClearDepthf(float depth)
		{
			GL.ClearDepth(depth);
		}

		public override void glClearStencil(int s)
		{
			GL.ClearStencil(s);
		}

		public override void glColorMask(bool red, bool green, bool blue, bool alpha)
		{
			GL.ColorMask(red, green, blue, alpha);
		}

		public override void glCompileShader(int shader)
		{
			GL.CompileShader(shader);
		}

		public override void glCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			GL.CompressedTexImage2D((TextureTarget)target, level, (PixelInternalFormat)internalformat, width, height, border, imageSize, data);
		}

		public override void glCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data)
		{
			GL.CompressedTexSubImage2D((TextureTarget)target, level, xoffset, yoffset, width, height, (PixelFormat)format, imageSize, data);
		}

		public override void glCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border)
		{
			GL.CopyTexImage2D((TextureTarget)target, level, (PixelInternalFormat)internalformat, x, y, width, height, border);
		}

		public override void glCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			GL.CopyTexSubImage2D((TextureTarget)target, level, xoffset, yoffset, x, y, width, height);
		}

		public override int glCreateProgram()
		{
			return GL.CreateProgram();
		}

		public override int glCreateShader(int shaderType)
		{
			return GL.CreateShader((ShaderType)shaderType);
		}

		public override void glCullFace(int mode)
		{
			GL.CullFace((CullFaceMode)mode);
		}

		public override unsafe void glDeleteBuffers(int n, IntPtr buffers)
		{
			GL.DeleteBuffers(n, (int*)buffers);
		}

		public override unsafe void glDeleteFramebuffers(int n, IntPtr framebuffers)
		{
			GL.DeleteFramebuffers(n, (int*)framebuffers);
		}

		public override void glDeleteProgram(int program)
		{
			GL.DeleteProgram(program);
		}

		public override unsafe void glDeleteRenderbuffers(int n, IntPtr renderbuffers)
		{
			GL.DeleteRenderbuffers(n, (int*)renderbuffers);
		}

		public override void glDeleteShader(int shader)
		{
			GL.DeleteShader(shader);
		}

		public override unsafe void glDeleteTextures(int n, IntPtr textures)
		{
			GL.DeleteTextures(n, (int*)textures);
		}

		public override void glDepthFunc(int func)
		{
			GL.DepthFunc((DepthFunction)func);
		}

		public override void glDepthMask(bool flag)
		{
			GL.DepthMask(flag);
		}

		public override void glDepthRangef(float nearVal, float farVal)
		{
			GL.DepthRange(nearVal, farVal);
		}

		public override void glDetachShader(int program, int shader)
		{
			GL.DetachShader(program, shader);
		}

		public override void glDisable(int cap)
		{
			GL.Disable((EnableCap)cap);
		}

		public override void glDisableVertexAttribArray(int index)
		{
			GL.DisableVertexAttribArray(index);
		}

		public override void glDrawArrays(int mode, int first, int count)
		{
			GL.DrawArrays((BeginMode)mode, first, count);
		}

		public override void glDrawElements(int mode, int count, int type, IntPtr indices)
		{
			GL.DrawElements((BeginMode)mode, count, (DrawElementsType)type, indices);
		}

		public override void glEnable(int cap)
		{
			GL.Enable((EnableCap)cap);
		}

		public override void glEnableVertexAttribArray(int index)
		{
			GL.EnableVertexAttribArray(index);
		}

		public override void glFinish()
		{
			GL.Finish();
		}

		public override void glFlush()
		{
			GL.Flush();
		}

		public override void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, int renderbuffer)
		{
			GL.FramebufferRenderbuffer((FramebufferTarget)target, (FramebufferAttachment)attachment, (RenderbufferTarget)renderbuffertarget, renderbuffer);
		}

		public override void glFramebufferTexture2D(int target, int attachment, int textarget, int texture, int level)
		{
			GL.FramebufferTexture2D((FramebufferTarget)target, (FramebufferAttachment)attachment, (TextureTarget)textarget, texture, level);
		}

		public override void glFrontFace(int mode)
		{
			GL.FrontFace((FrontFaceDirection)mode);
		}

		public override unsafe void glGenBuffers(int n, IntPtr buffers)
		{
			GL.GenBuffers(n, (int*)buffers);
		}

		public override unsafe void glGenFramebuffers(int n, IntPtr framebuffers)
		{
			GL.GenFramebuffers(n, (int*)framebuffers);
		}

		public override unsafe void glGenRenderbuffers(int n, IntPtr renderbuffers)
		{
			GL.GenRenderbuffers(n, (int*)renderbuffers);
		}

		public override unsafe void glGenTextures(int n, IntPtr textures)
		{
			GL.GenTextures(n, (int*)textures);
		}

		public override void glGenerateMipmap(int target)
		{
			GL.GenerateMipmap((GenerateMipmapTarget)target);
		}

		public override unsafe void glGetBooleanv(int pname, IntPtr parameters)
		{
			GL.GetBoolean((GetPName)pname, (bool*)parameters);
		}

		public override unsafe void glGetFloatv(int pname, IntPtr parameters)
		{
			GL.GetFloat((GetPName)pname, (float*)parameters);
		}

		public override unsafe void glGetIntegerv(int pname, IntPtr parameters)
		{
			GL.GetInteger((GetPName)pname, (int*)parameters);
		}

		public override unsafe void glGetActiveAttrib(int program, int index, int bufSize, IntPtr length, IntPtr size, IntPtr type, System.Text.StringBuilder name)
		{
			GL.GetActiveAttrib(program, index, bufSize, (int*)length, (int*)size, (ActiveAttribType*)type, name);
		}

		public override unsafe void glGetActiveUniform(int program, int index, int bufSize, IntPtr length, IntPtr size, IntPtr type, System.Text.StringBuilder name)
		{
			GL.GetActiveUniform(program, index, bufSize, (int*)length, (int*)size, (ActiveUniformType*)type, name);
		}

		public override unsafe void glGetAttachedShaders(int program, int maxCount, IntPtr count, IntPtr shaders)
		{
			GL.GetAttachedShaders(program, maxCount, (int*)count, (int*)shaders);
		}

		public override int glGetAttribLocation(int program, string name)
		{
			return GL.GetAttribLocation(program, name);
		}

		public override unsafe void glGetBufferParameteriv(int target, int value, IntPtr data)
		{
			GL.GetBufferParameter((BufferTarget)target, (BufferParameterName)value, (int*)data);
		}

		public override int glGetError()
		{
			return (int)GL.GetError();
		}

		public override unsafe void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, IntPtr parameters)
		{
			GL.GetFramebufferAttachmentParameter((FramebufferTarget)target, (FramebufferAttachment)attachment, (FramebufferParameterName)pname, (int*)parameters);
		}

		public override unsafe void glGetProgramInfoLog(int program, int maxLength, IntPtr length, System.Text.StringBuilder infoLog)
		{
			GL.GetProgramInfoLog(program, maxLength, (int*)length, infoLog);
		}

		public override unsafe void glGetProgramiv(int program, int pname, IntPtr parameters)
		{
			GL.GetProgram(program, (ProgramParameter)pname, (int*)parameters);
		}

		public override unsafe void glGetRenderbufferParameteriv(int target, int pname, IntPtr parameters)
		{
			GL.GetRenderbufferParameter((RenderbufferTarget)target, (RenderbufferParameterName)pname, (int*)parameters);
		}

		public override unsafe void glGetShaderInfoLog(int shader, int maxLength, IntPtr length, System.Text.StringBuilder infoLog)
		{
			GL.GetShaderInfoLog(shader, maxLength, (int*)length, infoLog);
		}

		public override unsafe void glGetShaderPrecisionFormat(int shaderType, int precisionType, IntPtr range, IntPtr precision)
		{
			GL.GetShaderPrecisionFormat((ShaderType)shaderType, (ShaderPrecisionType)precisionType, (int*)range, (int*)precision);
		}

		public override unsafe void glGetShaderSource(int shader, int maxLength, IntPtr length, System.Text.StringBuilder source)
		{
			GL.GetShaderSource(shader, maxLength, (int*)length, source);
		}

		public override unsafe void glGetShaderiv(int shader, int pname, IntPtr parameters)
		{
			GL.GetShader(shader, (ShaderParameter)pname, (int*)parameters);
		}

		public override string glGetString(int name)
		{
			return GL.GetString((StringName)name);
		}

		public override unsafe void glGetTexParameterfv(int target, int pname, IntPtr parameters)
		{
			GL.GetTexParameter((TextureTarget)target, (GetTextureParameter)pname, (float*)parameters);
		}

		public override unsafe void glGetTexParameteriv(int target, int pname, IntPtr parameters)
		{
			GL.GetTexParameter((TextureTarget)target, (GetTextureParameter)pname, (int*)parameters);
		}

		public override unsafe void glGetUniformfv(int program, int location, IntPtr parameters)
		{
			GL.GetUniform(program, location, (float*)parameters);
		}

		public override unsafe void glGetUniformiv(int program, int location, IntPtr parameters)
		{
			GL.GetUniform(program, location, (int*)parameters);
		}

		public override int glGetUniformLocation(int program, string name)
		{
			return GL.GetUniformLocation(program, name);
		}

		public override unsafe void glGetVertexAttribfv(int index, int pname, IntPtr parameters)
		{
			GL.GetVertexAttrib(index, (VertexAttribParameter)pname, (float*)parameters);
		}

		public override unsafe void glGetVertexAttribiv(int index, int pname, IntPtr parameters)
		{
			GL.GetVertexAttrib(index, (VertexAttribParameter)pname, (int*)parameters);
		}

		public override unsafe void glGetVertexAttribPointerv(int index, int pname, IntPtr pointer)
		{
			GL.GetVertexAttribPointer(index, (VertexAttribPointerParameter)pname, pointer);
		}

		public override void glHint(int target, int mode)
		{
			GL.Hint((HintTarget)target, (HintMode)mode);
		}

		public override bool glIsBuffer(int buffer)
		{
			return GL.IsBuffer(buffer);
		}

		public override bool glIsEnabled(int cap)
		{
			return GL.IsEnabled((EnableCap)cap);
		}

		public override bool glIsFramebuffer(int framebuffer)
		{
			return GL.IsFramebuffer(framebuffer);
		}

		public override bool glIsProgram(int program)
		{
			return GL.IsProgram(program);
		}

		public override bool glIsRenderbuffer(int renderbuffer)
		{
			return GL.IsRenderbuffer(renderbuffer);
		}

		public override bool glIsShader(int shader)
		{
			return GL.IsShader(shader);
		}

		public override bool glIsTexture(int texture)
		{
			return GL.IsTexture(texture);
		}

		public override void glLineWidth(float width)
		{
			GL.LineWidth(width);
		}

		public override void glLinkProgram(int program)
		{
			GL.LinkProgram(program);
		}

		public override void glPixelStorei(int pname, int param)
		{
			GL.PixelStore((PixelStoreParameter)pname, param);
		}

		public override void glPolygonOffset(float factor, float units)
		{
			GL.PolygonOffset(factor, units);
		}

		public override void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels)
		{
			GL.ReadPixels(x, y, width, height, (PixelFormat)format, (PixelType)type, pixels);
		}

		public override void glReleaseShaderCompiler()
		{
			GL.ReleaseShaderCompiler();
		}

		public override void glRenderbufferStorage(int target, int internalformat, int width, int height)
		{
			GL.RenderbufferStorage((RenderbufferTarget)target, (RenderbufferStorage)internalformat, width, height);
		}

		public override void glSampleCoverage(float value, bool invert)
		{
			GL.SampleCoverage(value, invert);
		}

		public override void glScissor(int x, int y, int width, int height)
		{
			GL.Scissor(x, y, width, height);
		}

		public override unsafe void glShaderBinary(int n, IntPtr shaders, int binaryformat, IntPtr binary, int length)
		{
			GL.ShaderBinary(n, (int*)shaders, (BinaryFormat)binaryformat, binary, length);
		}

		public override unsafe void glShaderSource(int shader, int count, string[] str, IntPtr length)
		{
			GL.ShaderSource(shader, count, str, (int*)length);
		}

		public override void glStencilFunc(int func, int reference, int mask)
		{
			GL.StencilFunc((StencilFunction)func, reference, mask);
		}

		public override void glStencilFuncSeparate(int face, int func, int reference, int mask)
		{
			GL.StencilFuncSeparate((Version20)face, (StencilFunction)func, reference, mask);
		}

		public override void glStencilMask(int mask)
		{
			GL.StencilMask(mask);
		}

		public override void glStencilMaskSeparate(int face, int mask)
		{
			GL.StencilMaskSeparate((StencilFace)face, mask);
		}

		public override void glStencilOp(int sfail, int dpfail, int dppass)
		{
			GL.StencilOp((StencilOp)sfail, (StencilOp)dpfail, (StencilOp)dppass);
		}

		public override void glStencilOpSeparate(int face, int sfail, int dpfail, int dppass)
		{
			GL.StencilOpSeparate((StencilFace)face, (StencilOp)sfail, (StencilOp)dpfail, (StencilOp)dppass);
		}

		public override void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr data)
		{
			GL.TexImage2D((TextureTarget)target, level, (PixelInternalFormat)internalformat, width, height, border, (PixelFormat)format, (PixelType)type, data);
		}

		public override void glTexParameterf(int target, int pname, float param)
		{
			GL.TexParameter((TextureTarget)target, (TextureParameterName)pname, param);
		}

		public override unsafe void glTexParameterfv(int target, int pname, IntPtr parameters)
		{
			GL.TexParameter((TextureTarget)target, (TextureParameterName)pname, (float*)parameters);
		}

		public override void glTexParameteri(int target, int pname, int param)
		{
			GL.TexParameter((TextureTarget)target, (TextureParameterName)pname, param);
		}

		public override unsafe void glTexParameteriv(int target, int pname, IntPtr parameters)
		{
			GL.TexParameter((TextureTarget)target, (TextureParameterName)pname, (int*)parameters);
		}

		public override void glTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr data)
		{
			GL.TexSubImage2D((TextureTarget)target, level, xoffset, yoffset, width, height, (PixelFormat)format, (PixelType)type, data);
		}

		public override void glUniform1f(int location, float v0)
		{
			GL.Uniform1(location, v0);
		}

		public override unsafe void glUniform1fv(int location, int count, IntPtr value)
		{
			GL.Uniform1(location, count, (float*)value);
		}

		public override void glUniform1i(int location, int v0)
		{
			GL.Uniform1(location, v0);
		}

		public override unsafe void glUniform1iv(int location, int count, IntPtr value)
		{
			GL.Uniform1(location, count, (int*)value);
		}

		public override void glUniform2f(int location, float v0, float v1)
		{
			GL.Uniform2(location, v0, v1);
		}

		public override unsafe void glUniform2fv(int location, int count, IntPtr value)
		{
			GL.Uniform2(location, count, (float*)value);
		}

		public override void glUniform2i(int location, int v0, int v1)
		{
			GL.Uniform2(location, v0, v1);
		}

		public override unsafe void glUniform2iv(int location, int count, IntPtr value)
		{
			GL.Uniform2(location, count, (int*)value);
		}

		public override void glUniform3f(int location, float v0, float v1, float v2)
		{
			GL.Uniform3(location, v0, v1, v2);
		}

		public override unsafe void glUniform3fv(int location, int count, IntPtr value)
		{
			GL.Uniform3(location, count, (float*)value);
		}

		public override void glUniform3i(int location, int v0, int v1, int v2)
		{
			GL.Uniform3(location, v0, v1, v2);
		}

		public override unsafe void glUniform3iv(int location, int count, IntPtr value)
		{
			GL.Uniform3(location, count, (int*)value);
		}

		public override void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			GL.Uniform4(location, v0, v1, v2, v3);
		}

		public override unsafe void glUniform4fv(int location, int count, IntPtr value)
		{
			GL.Uniform4(location, count, (float*)value);
		}

		public override void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			GL.Uniform4(location, v0, v1, v2, v3);
		}

		public override unsafe void glUniform4iv(int location, int count, IntPtr value)
		{
			GL.Uniform4(location, count, (int*)value);
		}

		public override unsafe void glUniformMatrix2fv(int location, int count, bool transpose, IntPtr value)
		{
			GL.UniformMatrix2(location, count, transpose, (float*)value);
		}

		public override unsafe void glUniformMatrix3fv(int location, int count, bool transpose, IntPtr value)
		{
			GL.UniformMatrix3(location, count, transpose, (float*)value);
		}

		public override unsafe void glUniformMatrix4fv(int location, int count, bool transpose, IntPtr value)
		{
			GL.UniformMatrix4(location, count, transpose, (float*)value);
		}

		public override void glUseProgram(int program)
		{
			GL.UseProgram(program);
		}

		public override void glValidateProgram(int program)
		{
			GL.ValidateProgram(program);
		}

		public override void glVertexAttrib1f(int index, float v0)
		{
			GL.VertexAttrib1(index, v0);
		}

		public override unsafe void glVertexAttrib1fv(int index, IntPtr v)
		{
			GL.VertexAttrib1(index, (float*)v);
		}

		public override void glVertexAttrib2f(int index, float v0, float v1)
		{
			GL.VertexAttrib2(index, v0, v1);
		}

		public override unsafe void glVertexAttrib2fv(int index, IntPtr v)
		{
			GL.VertexAttrib2(index, (float*)v);
		}

		public override void glVertexAttrib3f(int index, float v0, float v1, float v2)
		{
			GL.VertexAttrib3(index, v0, v1, v2);
		}

		public override unsafe void glVertexAttrib3fv(int index, IntPtr v)
		{
			GL.VertexAttrib3(index, (float*)v);
		}

		public override void glVertexAttrib4f(int index, float v0, float v1, float v2, float v3)
		{
			GL.VertexAttrib4(index, v0, v1, v2, v3);
		}

		public override unsafe void glVertexAttrib4fv(int index, IntPtr v)
		{
			GL.VertexAttrib4(index, (float*)v);
		}

		public override void glVertexAttribPointer(int index, int size, int type, bool normalized, int stride, IntPtr pointer)
		{
			GL.VertexAttribPointer(index, size, (VertexAttribPointerType)type, normalized, stride, pointer);
		}

		public override void glViewport(int x, int y, int width, int height)
		{
			GL.Viewport(x, y, width, height);
		}
	}
}

