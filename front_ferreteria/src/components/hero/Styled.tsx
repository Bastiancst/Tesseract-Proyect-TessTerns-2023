import styled from "styled-components";

export const CarouselImg = styled.img`
  max-width: 500px;
  min-width: xs;
  width: 100%;
  opacity: 1;
  transition: 1s;
`;

export const CarouselButtonContainer = styled.div`
  display: flex;
  align-content: center;
  flex-direction: row;
  margin-top: 15px;
`;

export const CarouselButton = styled.button`
  color: white;
  background-color: #eb118a;
  padding: 8px;
  margin: 0 5px;
  align: center;
`;

export interface Props {
  images: string[];
  autoPlay?: boolean;
  showButtons?: boolean;
}
