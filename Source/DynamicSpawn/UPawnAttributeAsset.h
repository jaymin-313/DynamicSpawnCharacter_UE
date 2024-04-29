// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/DataAsset.h"
#include "UPawnAttributeAsset.generated.h"

/**
 * 
 */
UCLASS()
class DYNAMICSPAWN_API UUPawnAttributeAsset : public UDataAsset
{
	GENERATED_BODY()
	
public:
	UPROPERTY(EditAnywhere,BlueprintReadWrite,Category = "Pawn Attributes")
	float Speed;

	UPROPERTY(EditAnywhere,BlueprintReadWrite,Category = "Pawn Attributes")
	float Health;

	UPROPERTY(EditAnywhere,BlueprintReadWrite,Category = "Pawn Attributes")
	float JumpHeight;

};
