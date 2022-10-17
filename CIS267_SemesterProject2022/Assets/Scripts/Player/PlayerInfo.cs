using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInfo
{
    private static bool isWalking;
    private static bool isFlying;
    private static float jetPackForce;
    private static float walkSpeed;
    private static bool isGrounded;

    public static bool getIsWalking()
    {
        return isWalking;
    }

    public static void setIsWalking(bool walking)
    {
        isWalking = walking;
    }

    public static bool getIsFlying()
    {
        return isFlying;
    }

    public static void setIsFlying(bool flying)
    {
        isFlying = flying;
    }

    public static float getJetPackForce()
    {
        return jetPackForce;
    }

    public static void setJetPackForce(float force)
    {
        jetPackForce = force;
    }

    public static float getWalkSpeed()
    {
        return walkSpeed;
    }

    public static void setWalkSpeed(float speed)
    {
        walkSpeed = speed;
    }

    public static bool getIsGrounded()
    {
        return isGrounded;
    }

    public static void setIsGrounded(bool grounded)
    {
        isGrounded = grounded;
    }
}
