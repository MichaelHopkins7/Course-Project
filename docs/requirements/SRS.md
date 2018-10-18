# Requirements


## Make a new Character

## Calculate Attributes
 - CA1*Use class levels(ref: UI4) to calculate Hit Die Total.
 - CA2*Use Hit Die Total(ref: CA1) to calculate feat total.
 - CA3*Use Hit Die Total(ref: CA1) to calculate number of stat advances.
 - CA4*Use BAB from class(es)(ref: UI3 & UI4) with STR(ref: UI10) score and size(ref: UI2) to calculate melee attack bonus.
 - CA5*Use BAB from class(es)(ref: UI3 & UI4) with DEX(ref: UI10) score and size(ref: UI2) to calculate ranged attack bonus.
 - CA6*Use Fort from class(es)(ref: UI3 & UI4) with CON(ref: UI10) score to calculate fortitude save.
 - CA7*Use Ref from class(es)(ref: UI3 & UI4) with DEX(ref: UI10) score to calculate reflex save.
 - CA8*Use Will from class(es)(ref: UI3 & UI4) with WIS(ref: UI10) score to calculate will save.
 - CA9*Use Hit Die Total(ref: CA1) with CON(ref: UI10) and Die size to calculate hit points.
 - CA10*Use class skills(ref: UI3) with skill allocation(ref: UI9) to calculate skill bonuses.
 - CA11*Apply size(ref: UI2) bonuses and penalties to applicable skills(ref: CA10).
	
## Database Requirements	
	
## Display Character sheet
 - DCS1*Display Character Name(ref:UI1)
 - DCS2*Display Character hit point total(ref: CA12)
 - DCS3*Display Fort save bonus(ref: CA9
 - DCS4*Display Ref save bonus(ref: CA10)
 - DCS5*Display Will save bonus(ref: CA11)
 - DCS6*Display Melee attack Bonus(ref: CA7)
 - DCS7*Display Ranged attack Bonus(ref: CA8)
 - DCS8*Display Skill bonuses(ref: CA13)
	
## Generate Character
 - GC1*Create character ID to connect character details to.
 - GC2*Use user input for Stat generation system(ref: UI7) to determine starting stats.
 - GC3*Apply race stat modifiers(ref: UI2) to starting stats(ref: GC2).
	
## User Input
 - UI1*Accept a character name from the user.
 - UI2*Accept a character race from the user.
 - UI3*Accept multiple character classes from the user.
 - UI4*Accept a level for each classes(ref : UI3).
 - UI5*Accept character feats from the user.
 - UI6*Accept character skill rank allocation from the user.
 - UI7*Accept Stat generation system from user.
 - UI8*Advance level by level to select feats(ref: UI5).
 - UI9*Advance level by level to apply skill ranks(ref: UI6).
 - UI10*Apply stat advances(ref: CA3) to character stats(ref: UI8) by user input.
