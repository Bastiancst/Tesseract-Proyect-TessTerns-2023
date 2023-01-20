import { useEffect, useState } from "react";
import { CarouselImg } from "./Styled";
import { CarouselButton } from "./Styled";
import { CarouselButtonContainer } from "./Styled";
import { Props } from "./Styled";

export default function Carousel(props: Props) {
    const [selectedIndex, setSelectedIndex] = useState(0);
    const [selectedImage, setSelectedImage] = useState(props.images[0]);

    useEffect(() => {
        if (props.autoPlay || !props.showButtons) {
        const interval = setInterval(() => {
            selectNewImage(selectedIndex, props.images);
        }, 3500);
        return () => clearInterval(interval);
        }
    });

    const selectNewImage = (index: number, images: string[], next = true) => {
        setTimeout(() => {
        const condition = next ? selectedIndex < images.length - 1 : selectedIndex > 0;
        const nextIndex = next ? (condition ? selectedIndex + 1 : 0) : condition ? selectedIndex - 1 : images.length - 1;
        setSelectedImage(images[nextIndex]);
        setSelectedIndex(nextIndex);
        }, 50);
    };

    const previous = () => {
        selectNewImage(selectedIndex, props.images, false);
    };

    const next = () => {
        selectNewImage(selectedIndex, props.images);
    };
    return (
        <div id="container">
        <CarouselImg id="img"
            src={selectedImage}
        />
        <CarouselButtonContainer id="btn">
            {props.showButtons ? (
            <>
                <CarouselButton onClick={previous}>{"<"}</CarouselButton>
                <CarouselButton onClick={next}>{">"}</CarouselButton>
            </>
            ) : (
            <></>
            )}
        </CarouselButtonContainer>
        </div>
    );
}