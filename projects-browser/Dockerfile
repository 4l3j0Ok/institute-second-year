FROM node:lts-alpine AS base

WORKDIR /app

ENV PNPM_HOME="/pnpm"
ENV PATH="$PNPM_HOME:$PATH"
RUN corepack enable

COPY package.json pnpm-lock.yaml ./
RUN pnpm install --prod

COPY . .

RUN pnpm run prebuild
RUN pnpm run build

FROM base AS production
COPY --from=base /app/dist ./dist
CMD ["echo", "Build complete"]