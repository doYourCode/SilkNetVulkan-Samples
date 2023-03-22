﻿
namespace Chapter20aDescriptorSetsNoBuilder;

public struct FrameInfo
{
    public int FrameIndex;// { get; set; }
    public float FrameTime;// { get; set; }
    public CommandBuffer CommandBuffer;// { get; init; }
    public OrthographicCamera Camera;// { get; init; } = null!;
    public DescriptorSet GlobalDescriptorSet;// { get; init; }
}


