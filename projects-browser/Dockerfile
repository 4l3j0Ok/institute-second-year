FROM node:lts-alpine AS base

WORKDIR /app

ENV PNPM_HOME="/pnpm"
ENV PATH="$PNPM_HOME:$PATH"
RUN corepack enable

RUN pnpm install --prod
RUN pnpm run build

FROM base AS production
COPY --from=base /app/dist ./dist
CMD ["echo", "Build complete"]